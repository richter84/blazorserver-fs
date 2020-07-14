using BlazorServerLibrary.Models;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using BlazorServerService.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BlazorServerService_FS_Tests
{
    public class CustomerServiceTest : ServiceTestBase
    {
        public CustomerServiceTest()
            : base(new DbContextOptionsBuilder<DataContext>()
                  .UseInMemoryDatabase("InMemoryDataContext")
                  .Options)
        {
        }

        [Fact]
        public async Task GetCustomer_ReturnsFoundCustomer_WithAddress()
        {
            using var context = new DataContext(ContextOptions);
            var customerId = 1;
            var customerService = FactoryService.CreateCustomerService(context);

            var customer = await customerService.GetCustomer(customerId);

            Assert.Equal("Customer One", customer.Name);
            Assert.Equal(2, customer.Address.Count);
        }

        [Fact]
        public async Task GetCustomer_ReturnsFoundCustomer_WithoutAddress()
        {
            using var context = new DataContext(ContextOptions);
            var customerId = 2;
            var customerService = FactoryService.CreateCustomerService(context);

            var customer = await customerService.GetCustomer(customerId);

            Assert.Equal("Customer Two", customer.Name);
            Assert.NotNull(customer.Address);
        }

        [Fact]
        public async Task GetCustomer_ReturnsNotFoundCustomer()
        {
            using var context = new DataContext(ContextOptions);
            var customerId = 200;
            var customerService = FactoryService.CreateCustomerService(context);

            var customer = await customerService.GetCustomer(customerId);

            Assert.Null(customer);
        }

        [Fact]
        public async Task AddorUpdate_AddNewCustomer_ReturnsCustomer()
        {
            using var context = new DataContext(ContextOptions);
            var newCustomer = FactoryService.CreateCustomer();
            var customerService = FactoryService.CreateCustomerService(context);
            var customer = await customerService.AddorUpdate(newCustomer);

            Assert.Equal("Customer Four", customer.Name);
            Assert.True(customer.Id > 0);
        }


        [Fact]
        public async Task AddorUpdate_UpdateExistingCustomerName_ReturnsCustomer()
        {
            using var context = new DataContext(ContextOptions);
            var existingCustomer = context.Customers.Find(1);
            existingCustomer.Name = "Customer One Updated";

            var customerService = new CustomerService(context);
            var customer = await customerService.AddorUpdate(existingCustomer);

            Assert.Equal(1, customer.Id);
            Assert.Equal("Customer One Updated", customer.Name);
        }
    }
}
