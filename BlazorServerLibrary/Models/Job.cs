using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public abstract class Job : IJob
    {
        public int Id { get; set; }
        public abstract string SerialNumber { get; set; }
        public JobStatus Status { get; set; }
        public Customer Customer { get; set; }
        public abstract Door Door { get; set; }
        public ICollection<HistoryStatus> History { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
