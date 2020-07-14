using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Doors;
using BlazorServerLibrary.Models.Jobs;
using BlazorServerService.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorServerService_FS_Tests
{
    public abstract class ServiceTestBase
    {
        protected DbContextOptions<DataContext> ContextOptions { get; }
        public ServiceTestBase(DbContextOptions<DataContext> contextOptions)
        {
            ContextOptions = contextOptions;
            Seed();
        }
        private void Seed()
        {
            using var context = new DataContext(ContextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var addresses = FactoryService.CreateBatchOfAddresses();

            context.Addresses.AddRange(addresses);

            var customers = FactoryService.CreateBatchOfCustomers();

            context.Customers.AddRange(customers);

            var invoice = FactoryService.CreateInvoice();

            context.Invoices.AddRange(invoice);

            var newInstalls = new NewInstall()
            {
                Id = 1,
                Customer = customers.FirstOrDefault(),
                Door = new RollerShutterDoor()
            };

            context.NewInstalls.AddRange(newInstalls);

            context.SaveChanges();
        }
    }
}
