﻿using BlazorServerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface IDoor
    {
        string Colour { get; set; }
        string ExtraNotes { get; set; }
        string FixingType { get; set; }
        bool IsSupplied { get; set; }
        string Manufacturer { get; set; }
        double OpeningSizeHeight { get; set; }
        double OpeningSizeWidth { get; set; }
        SectorType Sector { get; set; }
        string SupplierOrderNumber { get; set; }
    }
}
