using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Models;
using System.Collections.Generic;

namespace BlazorServerLibrary.Interfaces
{
    public interface IElectricOperation
    {
        string Control { get; set; }
        List<ElectricalSafetySelection> ElectricalSafety { get; set; }
        int Id { get; set; }
        string MotorType { get; set; }
        int PECQty { get; set; }
        ElectricalSupplyType SupplyType { get; set; }
    }
}