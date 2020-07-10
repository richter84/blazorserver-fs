using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models.Doors
{
    public class SectionalDoor : Door, ISectional, IDoorType
    {
        public AntiFallSafety AntiFallSafety { get; set; }
        public double Cable { get; set; }
        public override DoorType DoorType { get; set; } = DoorType.Sectional;
        public ElectricOperation ElectricOperation { get; set; }
        public string LiftType { get; set; }
        public int NumberOfSprings { get; set; }
        public OperationType OperationType { get; set; }
        public double OverJambSize { get; set; }
        public double PanelOECSize { get; set; }
        public double ShaftSize { get; set; }
        public double ShaftLength { get; set; }
        public double SizeToSpringAssembly { get; set; }
        public double SpringSize { get; set; }
        public double SpringLength { get; set; }
        public double TopOfTrackSize { get; set; }
        public bool WicketEuroDoor { get; set; }
    }
}
