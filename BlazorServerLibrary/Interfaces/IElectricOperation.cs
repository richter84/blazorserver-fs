using BlazorServerLibrary.Enums;

namespace BlazorServerLibrary.Interfaces
{
    public interface IElectricOperation
    {
        string Control { get; set; }
        ElectricalSafety ElectricalSafety { get; set; }
        int Id { get; set; }
        string MotorType { get; set; }
        int PECQty { get; set; }
        ElectricalSupplyType SupplyType { get; set; }
    }
}