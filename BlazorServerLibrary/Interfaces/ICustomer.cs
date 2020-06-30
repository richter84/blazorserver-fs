using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    interface ICustomer
    {
        string Name { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
        DateTimeOffset Created { get; set; }
        DateTimeOffset LastUpdate { get; set; }
    }
}
