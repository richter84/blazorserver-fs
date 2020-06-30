using BlazorServerLibrary.Models;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerService.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;

        public CustomerService(DataContext context)
        {
            _context = context;
        }
        public async Task<Customer> AddorUpdate(Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(customer.Id);

            if (existingCustomer == null)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                _context.Customers.Update(existingCustomer);
            }
            
            await _context.SaveChangesAsync();
            return customer;
        }

        public Task<Customer> Archive(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomer(int Id)
        {
            var query = from c in _context.Customers
                        where c.Id == Id
                        select c;


            return await _context.Customers
                .Include(c => c.Address)
                .FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.OrderBy(c => c.Name).ToListAsync();
        }
    }
}
