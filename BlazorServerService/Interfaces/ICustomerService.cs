﻿using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface ICustomerService<TEntity> : IService<TEntity> where TEntity : Customer
    {
        Task<Customer> GetCustomer(int Id);
        Task<List<Customer>> GetCustomers();
    }
}
