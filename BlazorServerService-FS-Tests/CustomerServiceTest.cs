using BlazorServerLibrary.Models;
using BlazorServerService.Data;
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
            var customerService = new CustomerService<Customer>(context);

            var customer = await customerService.GetCustomer(customerId);

            Assert.Equal("Customer One", customer.Name);
            Assert.Equal(2, customer.Address.Count);
        }

        [Fact]
        public async Task GetCustomer_ReturnsFoundCustomer_WithoutAddress()
        {
            using var context = new DataContext(ContextOptions);
            var customerId = 2;
            var customerService = new CustomerService<Customer>(context);

            var customer = await customerService.GetCustomer(customerId);

            Assert.Equal("Customer Two", customer.Name);
            Assert.NotNull(customer.Address);
        }

        [Fact]
        public async Task GetCustomer_ReturnsNotFoundCustomer()
        {
            using var context = new DataContext(ContextOptions);
            var customerId = 200;
            var customerService = new CustomerService<Customer>(context);

            var customer = await customerService.GetCustomer(customerId);

            Assert.Null(customer);
        }

        [Fact]
        public async Task AddorUpdate_AddNewCustomer_ReturnsCustomer()
        {
            using var context = new DataContext(ContextOptions);
            var newCustomer = new Customer()
            {
                Name = "Customer Four",
                EmailAddress = "ddd@example.com",
                PhoneNumber = "0700000004"
            };

            var customerService = new CustomerService<Customer>(context);
            var customer = await customerService.AddorUpdate(newCustomer);

            Assert.Equal("Customer Four", customer.Name);
            Assert.True(customer.Id > 0);
        }


        [Fact]
        public async Task AddorUpdate_UpdateExistingCustomerName_ReturnsCustomer()
        {
            using var context = new DataContext(ContextOptions);
            var existingCustomer = new Customer()
            {
                Id = 1,
                Name = "Customer One Updated",
                EmailAddress = "ddd@example.com",
                PhoneNumber = "0700000004"
            };

            var customerService = new CustomerService<Customer>(context);
            var customer = await customerService.AddorUpdate(existingCustomer);

            Assert.Equal(1, customer.Id);
            Assert.Equal("Customer One Updated", customer.Name);
        }
    }
}
