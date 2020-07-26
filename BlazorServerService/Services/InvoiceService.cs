using Azure.Storage.Blobs;
using BlazorServerService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.EventGrid;
using BlazorServerLibrary.Events;
using BlazorServerLibrary.Models;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Options;
using Azure;
using BlazorServerService.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO.Abstractions;

namespace BlazorServerService.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IFileSystem _fileSystem;
        private readonly IConfiguration Configuration;
        private readonly DataContext _context;
        public InvoiceService(IConfiguration configuration, DataContext context, IFileSystem fileSystem)
        {
            Configuration = configuration;
            _context = context;
            _fileSystem = fileSystem;
        }

        public async Task<Invoice> Add(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<List<Invoice>> GetInvoicesByJobId(int jobId)
        {
            return await _context.Invoices
                        .Include(i => i.InvoiceItems)
                        .Where(i => i.JobId == jobId).ToListAsync();
        }

        public async Task<List<InvoiceFile>> GetInvoicesFromAzureStorageByCustomerId(int customerId, int jobId)
        {
            List<InvoiceFile> InvoiceFiles = new List<InvoiceFile>();
            var containerName = $"invoices";
            string connectionString = Configuration["AzureStorage:FifeShutters:ConnectionString"];
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            try
            {
                await blobServiceClient.GetBlobContainerClient(containerName).ExistsAsync();
                BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
                var blobPages = blobContainerClient.GetBlobsByHierarchy(prefix: $"{customerId}/{jobId}/", delimiter:"/").AsPages();

                foreach (Page<BlobHierarchyItem> blobPage in blobPages)
                {
                    foreach (BlobHierarchyItem blobItem in blobPage.Values)
                    {
                        var uri = $"{blobContainerClient.Uri.AbsoluteUri}/{blobItem.Blob.Name}";
                        var createdOn = blobItem.Blob.Properties.CreatedOn.Value;
                        var filename = blobItem.Blob.Name;
                        InvoiceFile invoiceFile = new InvoiceFile() { CreatedOn = createdOn, Filename = filename, Url = uri };
                        InvoiceFiles.Add(invoiceFile);
                    }
                }

                return InvoiceFiles;
            }
            catch (RequestFailedException ex)
            {
                throw;
            }
        }

        public string PrepareInvoiceHtmlToPdf(Invoice invoice, Customer customer, string path)
        {
            string invoiceFile = _fileSystem.Path.Combine(path, "templates", "invoice.html");
            string html = _fileSystem.File.ReadAllText(invoiceFile);
            html.Replace("{{body}}", $"{customer.Name}, your job ({invoice.SerialNumber}) has been invoiced!");

            StringBuilder invoiceItemNames = new StringBuilder();
            StringBuilder invoiceItemPrices = new StringBuilder();
            foreach (var invoiceItem in invoice.InvoiceItems)
            {
                invoiceItemNames.Append($"<p>{invoiceItem.Name}</p>");
                invoiceItemPrices.Append($"<p>{invoiceItem.Price}</p>");
            }

            html = html.Replace("{{invoiceitems.name}}", invoiceItemNames.ToString())
            .Replace("{{invoiceitems.price}}", invoiceItemPrices.ToString())
            .Replace("{{subtotal}}", invoice.SubTotal.ToString())
            .Replace("{{vattotal}}", invoice.VatTotal.ToString())
            .Replace("{{total}}", invoice.Total.ToString());

            return html;
        }

        public async Task<string> UploadToAzureStorageAsync(string html, string filename, int customerId, int jobId)
        {
            SelectPdf.HtmlToPdf convert = new SelectPdf.HtmlToPdf();
            SelectPdf.PdfDocument doc = convert.ConvertHtmlString(html);
            var pdfBytes = doc.Save();
            try
            {
                using (Stream stream = new MemoryStream(pdfBytes))
                {
                    string connectionString = Configuration["AzureStorage:FifeShutters:ConnectionString"];
                    var containerName = $"invoices";
                    BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
                    //await blobContainerClient.CreateIfNotExistsAsync();
                    await blobContainerClient.UploadBlobAsync($"{customerId}/{jobId}/{filename}", stream);
                    return filename;
                }
            }
            catch(Exception e) { throw e; }
        }

        public async Task PublishInvoiceCreatedToEventGrid(InvoiceCreatedEvent invoiceCreatedEventData)
        {
            string TopicEndpoint = "https://invoicecreated.uksouth-1.eventgrid.azure.net/api/events"; //Configuration["AppSettings:TopicEndpoint"];
            string TopicKey = "4B7Wi9qpCRyCtaq58iqGNI7POTChFHnFPLbYZPi0y/w="; //Configuration["AppSettings:TopicKey"];
            string topicHostname = new Uri(TopicEndpoint).Host;

            TopicCredentials topicCredentials = new TopicCredentials(TopicKey);
            EventGridClient client = new EventGridClient(topicCredentials);

            EventGridEvent eventGridEvent = new EventGridEvent()
            {
                Id = Guid.NewGuid().ToString(),
                EventType = "invoiceCreated",
                Data = invoiceCreatedEventData,
                EventTime = DateTime.Now,
                Subject = "New Door",
                DataVersion = "2.0"
            };

            List<EventGridEvent> events = new List<EventGridEvent>();
            events.Add(eventGridEvent);

            await client.PublishEventsAsync(topicHostname, events);
        }
    }
}
