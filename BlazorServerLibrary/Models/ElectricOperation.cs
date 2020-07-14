using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class ElectricOperation : IElectricOperation
    {
        public int Id { get; set; }
        public string Control { get; set; }
        public ElectricalSafety ElectricalSafety { get; set; }
        public string MotorType { get; set; }
        public ElectricalSupplyType SupplyType { get; set; }
        public int PECQty { get; set; }
    }
}
