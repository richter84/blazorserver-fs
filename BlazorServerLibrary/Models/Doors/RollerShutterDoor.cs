﻿using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models.Doors
{
    public class RollerShutterDoor : Door, IRollerShutter
    {
        public string AngleCutSize { get; set; }
        public string AngleType { get; set; }
        public AntiFallSafety AntiFallSafety { get; set; }
        public string BGSize { get; set; }
        public bool Canopy { get; set; }
        public string CanopyType { get; set; }
        public string CanopyCutSize { get; set; }
        public string CurtainType { get; set; }
        public override DoorType DoorType { get; set; } = DoorType.RollerShutter;
        public ElectricOperation ElectricOperation { get; set; } =  new ElectricOperation();
        public string FHSize { get; set; }
        public bool Fascia { get; set; }
        public string FasciaType { get; set; }
        public string FasciaSize { get; set; }
        public FireDefence FireDefence { get; set; }
        public string GuideCutSize { get; set; }
        public string GuideType { get; set; }
        public bool IsBoltOnGuides { get; set; }
        public double LathCutSize { get; set; }
        public OperationType OperationType { get; set; }
        public string TubeTypeGauge { get; set; }
        public string RollerCutSize { get; set; }
        public bool WicketEuroDoor { get; set; }


    }
}
