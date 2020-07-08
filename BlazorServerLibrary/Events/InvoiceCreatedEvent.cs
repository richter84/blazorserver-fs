using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Events
{
    public class InvoiceCreatedEvent
    {
        public int JobId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmailAddress { get; set; }
        public double SubTotal { get; set; }
        public double VatTotal { get; set; }
        public IEnumerable<InvoiceItem> JobItems { get; set; }
        public string FileName { get; set; }
    }
}
