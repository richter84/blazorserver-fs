using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Job : IJob
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public JobStatus Status { get; set; }
        public ICustomer Customer { get; set; }
        public IDoor Door { get; set; }
        public IInvoice Invoice { get; set; }
        public Tuple<JobStatus, DateTimeOffset, int> History { get; set; }
    }
}
