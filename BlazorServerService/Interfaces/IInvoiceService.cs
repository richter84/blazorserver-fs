using BlazorServerLibrary.Events;
using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface IInvoiceService
    {
        Task<Invoice> Add(Invoice invoice);
        Task<List<Invoice>> GetInvoicesByJobId(int jobId);
        Task<List<InvoiceFile>> GetInvoicesFromAzureStorageByCustomerId(int customerId, int jobId);
        string PrepareInvoiceHtmlToPdf(Invoice invoice, Customer customer, string path);
        Task PublishInvoiceCreatedToEventGrid(InvoiceCreatedEvent invoiceCreatedEventData);
        Task<string> UploadToAzureStorageAsync(string html, string filename, int customerId, int jobId);
    }
}
