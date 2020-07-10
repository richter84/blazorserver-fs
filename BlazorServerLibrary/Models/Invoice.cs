using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Invoice : IInvoice
    {
        public int Id { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }

        [MaxLength(20)]
        public string SerialNumber { get; set; }

        [MaxLength(100)]
        public string FileName { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
        [DataType(DataType.Currency)]
        public double VatTotal { get; set; }

        [NotMapped]
        public double Total { get { return SubTotal + VatTotal; } }

    }
}
