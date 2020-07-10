using BlazorServerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models.Doors
{
    public class BarsGrillesDoor : Door
    {
        public override DoorType DoorType { get; set; } = DoorType.BarsGrilles;
        public double FH { get; set; }
        public double FW { get; set; }
    }
}
