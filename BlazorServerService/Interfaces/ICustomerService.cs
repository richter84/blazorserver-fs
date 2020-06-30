using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> Add(Customer customer);
        Task<Customer> Archive(Customer customer);
        Task<Customer> Delete(Customer customer);
        Task<Customer> Update(Customer customer);
    }
}
