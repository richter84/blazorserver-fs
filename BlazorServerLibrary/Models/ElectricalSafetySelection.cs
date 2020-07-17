using BlazorServerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class ElectricalSafetySelection
    {
        public int Id { get; set; }
        public ElectricalSafety ElectricalSafety { get; set; }
        
        [ForeignKey("ElectricOperationId")]
        public int ElectricOperationId { get; set; }
    }
}
