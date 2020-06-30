using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface IJob
    {
        string SerialNumber { get; set; }
        ICustomer Customer { get; set; }
        IDoor Door { get; set; }
        JobStatus Status { get; set; }
    }
}
