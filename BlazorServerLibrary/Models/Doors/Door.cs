using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorServerLibrary.Models.Doors
{
    public abstract class Door
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Colour { get; set; }
        public abstract DoorType DoorType { get; set; }
        public string ExtraNotes { get; set; }
        public string FixingType { get; set; }
        public bool IsSupplied { get; set; }
        public string Manufacturer { get; set; }
        public double OpeningSizeHeight { get; set; }
        public double OpeningSizeWidth { get; set; }
        [Required]
        public SectorType Sector { get; set; }
        public string SupplierOrderNumber { get; set; }
    }
}
