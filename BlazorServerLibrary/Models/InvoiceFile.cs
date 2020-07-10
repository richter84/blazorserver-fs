using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class InvoiceFile
    {
        public DateTimeOffset CreatedOn { get; set; }
        public string Filename { get; set; }
        public string Url { get; set; }
    }
}
