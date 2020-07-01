using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Invoice : IInvoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string FileName { get; set; }
    }
}
