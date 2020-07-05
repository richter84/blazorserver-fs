using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Doors;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface IJob
    {
        string SerialNumber { get; }
        Customer Customer { get; set; }
        Door Door { get; set; }
        JobStatus Status { get; set; }
        ICollection<HistoryStatus> History { get; set; }
        ICollection<Invoice> Invoices { get; set; }
    }
}
