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

namespace BlazorServerService.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IConfiguration Configuration;
        public InvoiceService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<Dictionary<string, string>> GetInvoicesFromAzureStorageByCustomerId(int customerId)
        {
            Dictionary<string, string> InvoiceFiles = new Dictionary<string, string>();
            var containerName = $"invoices";
            string connectionString = Configuration["AzureStorage:FifeShutters:ConnectionString"];
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            try
            {
                await blobServiceClient.GetBlobContainerClient(containerName).ExistsAsync();
                BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
                var blobPages = blobContainerClient.GetBlobsByHierarchy(prefix: $"{customerId}/", delimiter:"/").AsPages();

                foreach (Page<BlobHierarchyItem> blobPage in blobPages)
                {
                    foreach (BlobHierarchyItem blobItem in blobPage.Values)
                    {
                        var uri = $"{blobContainerClient.Uri.AbsoluteUri}/{blobItem.Blob.Name}";
                        var createdOn = blobItem.Blob.Properties.CreatedOn.Value.ToString("dddd, dd MMMM yyyy");
                        InvoiceFiles.Add(uri, createdOn);
                    }
                }

                return InvoiceFiles;
            }
            catch (RequestFailedException ex)
            {
                throw;
            }
        }

        public async Task<string> UploadToAzureStorageAsync(string html, string filename, int customerId)
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
                    await blobContainerClient.CreateIfNotExistsAsync();
                    await blobContainerClient.UploadBlobAsync($"{customerId}/{filename}", stream);
                    return filename;
                }
            }
            catch { throw; }

        }

        public async Task PublishTopicToEventGrid(string CustomerName, string CustomerEmailAddress, string filename)
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
                Data = new InvoiceCreatedEvent()
                {
                    JobId = 123123,
                    CustomerName = CustomerName,
                    CustomerEmailAddress = CustomerEmailAddress,
                    SubTotal = 30.99,
                    VatTotal = 5.99,
                    JobItems = new List<InvoiceItem>(),
                    FileName = filename
                },

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
