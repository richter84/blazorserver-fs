using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Events
{
    public class InvoiceCreatedEvent
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string FileName { get; set; }
        public string SerialNumber { get; set; }
        public double SubTotal { get; set; }
        public double VatTotal { get; set; }
        public double Total { get { return SubTotal + VatTotal; } }
        public IEnumerable<InvoiceItem> InvoiceItems { get; set; }
    }
}
