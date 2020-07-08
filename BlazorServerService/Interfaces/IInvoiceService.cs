using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface IInvoiceService
    {
        Task<Dictionary<string, string>> GetInvoicesFromAzureStorageByCustomerId(int customerId);
        Task PublishTopicToEventGrid(string CustomerName, string CustomerEmailAddress, string filename);
        Task<string> UploadToAzureStorageAsync(string html, string filename, int customerId);
    }
}
