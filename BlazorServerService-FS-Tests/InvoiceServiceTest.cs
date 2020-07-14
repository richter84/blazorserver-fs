using BlazorServerService.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlazorServerService_FS_Tests
{
    public class InvoiceServiceTest : ServiceTestBase
    {
        public InvoiceServiceTest()
            : base(new DbContextOptionsBuilder<DataContext>()
                  .UseInMemoryDatabase("InMemoryDataContext")
                  .Options)
        {
        }

        [Fact]
        public async Task GetInvoicesByJobId_ReturnsInvoices_WithJobItems()
        {
            using var context = new DataContext(ContextOptions);
            var jobId = 1;
            var invoiceService = FactoryService.CreateInvoiceService(context);

            var invoices = await invoiceService.GetInvoicesByJobId(jobId);

            Assert.NotEmpty(invoices);
            Assert.NotEmpty(invoices.First().InvoiceItems);
            Assert.Equal(1, invoices.First().Id);
        }

        [Fact]
        public void PrepareInvoiceHtmlToPdf_ReturnsHtmlString_WithReplacedText()
        {
            using var context = new DataContext(ContextOptions);
            var invoiceService = FactoryService.CreateInvoiceService(context);
            var invoice = FactoryService.CreateInvoice();
            var customer = FactoryService.CreateCustomer();
            string path = string.Empty;
            string name = "{{invoiceitems.name}}";
            string price = "{{invoiceitems.price}}";
            string subtotal = "{{subtotal}}";
            string vattotal = "{{vattotal}}";
            string total = "{{total}}";

            string result = invoiceService.PrepareInvoiceHtmlToPdf(invoice, customer, path);

            Assert.DoesNotContain(name, result);
            Assert.DoesNotContain(price, result);
            Assert.DoesNotContain(subtotal, result);
            Assert.DoesNotContain(vattotal, result);
            Assert.DoesNotContain(total, result);
        }

        [Fact]
        public void PrepareInvoiceHtmlToPdf_ReturnsFileNotFoundException()
        {
            using var context = new DataContext(ContextOptions);
            var invoiceService = FactoryService.CreateInvoiceServiceWithFileNotFound(context);
            var invoice = FactoryService.CreateInvoice();
            var customer = FactoryService.CreateCustomer();
            string path = string.Empty;

            Assert.Throws<FileNotFoundException>(() => invoiceService.PrepareInvoiceHtmlToPdf(invoice, customer, path));
        }
    }
}
