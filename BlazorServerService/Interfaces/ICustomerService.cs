using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> AddorUpdate(Customer customer);
        Task<Customer> Archive(Customer customer);
        Task<Customer> Delete(Customer customer);
        Task<Customer> GetCustomer(int Id);
        Task<List<Customer>> GetCustomers();
    }
}
