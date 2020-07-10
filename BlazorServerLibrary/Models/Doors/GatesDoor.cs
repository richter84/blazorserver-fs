using BlazorServerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models.Doors
{
    public class GatesDoor : Door
    {
        public override DoorType DoorType { get; set; } = DoorType.Gates;
        public bool IsHingedLeaf { get; set; }
        public bool IsHingesBottomTrack { get; set; }
        public Leafs Leafs { get; set; }
        public double OverJambSize { get; set; }
        public double OverTracksSize { get; set; }
    }
}
