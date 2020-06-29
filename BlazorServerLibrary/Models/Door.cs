using BlazorServerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public abstract class Door
    {
        public string Colour { get; set; }
        public string ExtraNotes { get; set; }
        public string FixingType { get; set; }
        public bool IsSupplied { get; set; }
        public string Manufacturer { get; set; }
        public double OpeningSizeHeight { get; set; }
        public double OpeningSizeWidth { get; set; }
        public SectorType Sector { get; set; }
        public string SupplierOrderNumber { get; set; }
    }
}
