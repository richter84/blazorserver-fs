using BlazorServerLibrary.Models;
using BlazorServerService.Data;
using BlazorServerService.Services;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;

namespace BlazorServerService_FS_Tests
{
    public static class FactoryService
    {
        public static CustomerService CreateCustomerService(DataContext context)
        {
            return new CustomerService(context);
        }

        public static InvoiceService CreateInvoiceService(DataContext context)
        {
            var html = "{{invoiceitems.name}}{{invoiceitems.price}}{{subtotal}}{{vattotal}}{{total}}";
            Mock<IConfiguration> configuration = new Mock<IConfiguration>();
            Mock<IFileSystem> fileSystem = new Mock<IFileSystem>();
            fileSystem.Setup(fs => fs.Path.Combine(It.IsAny<string>())).Returns(It.IsAny<string>());
            fileSystem.Setup(fs => fs.File.ReadAllText(It.IsAny<string>())).Returns(html);
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=test;AccountKey=test;EndpointSuffix=core.windows.net";
            configuration.Setup(c => c["AzureStorage:FifeShutters:ConnectionString"]).Returns(connectionString);

            return new InvoiceService(configuration.Object, context, fileSystem.Object);
        }

        public static InvoiceService CreateInvoiceServiceWithFileNotFound(DataContext context)
        {
            Mock<IConfiguration> configuration = new Mock<IConfiguration>();
            Mock<IFileSystem> fileSystem = new Mock<IFileSystem>();

            fileSystem.Setup(fs => fs.Path.Combine(It.IsAny<string>())).Returns(It.IsAny<string>());
            fileSystem.Setup(fs => fs.File.ReadAllText(It.IsAny<string>())).Throws<FileNotFoundException>();

            return new InvoiceService(configuration.Object, context, fileSystem.Object);
        }

        public static Customer CreateCustomer()
        {
            return new Customer()
            {
                Name = "Customer Factory",
                EmailAddress = "factorycreated@example.com",
                PhoneNumber = "07444123456"
            };
        }

        public static Customer[] CreateBatchOfCustomers()
        {
            return new Customer[]
            {
                    new Customer {
                        Name = "Customer One",
                        EmailAddress = "aaa@example.com",
                        PhoneNumber = "070000000001",
                        Address = CreateBatchOfAddresses().ToList()
                    },
                    new Customer {
                        Name = "Customer Two",
                        EmailAddress = "bbb@example.com",
                        PhoneNumber = "070000000002"
                    },
                    new Customer {
                        Name = "Customer Three",
                        EmailAddress = "ccc@example.com",
                        PhoneNumber = "070000000003"
                    },
            };
        }

        public static Address[] CreateBatchOfAddresses()
        {
            return new Address[]
            {
                    new Address {
                        Street = "123 Street",
                        TownCity = "Town",
                        Region = "Region",
                        PostCode = "AA1 1AA"
                    },
                    new Address {
                        Street = "456 Street",
                        TownCity = "City",
                        Region = "Region",
                        PostCode = "BB1 1BB"
                    },

            };
        }

        public static Invoice CreateInvoice()
        {
            return new Invoice
            {
                SerialNumber = "AAABBBCCCDDDEEE",
                JobId = 1,
                FileName = "AAABBBCCCDDDEEE.pdf",
                SubTotal = 100,
                VatTotal = 20,
                InvoiceItems = new InvoiceItem[]
                {
                    new InvoiceItem
                    {
                        Id = 1,
                        Name = "Part A",
                        Price = 60
                    },
                    new InvoiceItem
                    {
                        Id = 2,
                        Name = "Part B",
                        Price = 40
                    }
                }
            };
        }
    }
}
