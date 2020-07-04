using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
    }
}
