using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface IInvoice
    {
        int Id { get; set; }
        string InvoiceNumber { get; set; }
        ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
