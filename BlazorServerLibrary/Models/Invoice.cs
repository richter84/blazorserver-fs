using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Invoice : IInvoice
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string InvoiceNumber { get; set; }

        [MaxLength(100)]
        public string FileName { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
    }
}
