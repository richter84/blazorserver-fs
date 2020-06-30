using BlazorServerLibrary.Models;
using BlazorServerService.Interfaces;
using System;
using System.Threading.Tasks;

namespace BlazorServerService.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<Customer> Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Archive(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
