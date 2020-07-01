using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum DoorType
    {
        [Display(Name = "Roller Shutter")]
        RollerShutter = 1,
        Sectional = 2,
        Pedestrian = 3,
        Gates = 4,
        [Display(Name = "Bars / Grilles")]
        BarsGrilles = 5
    }
}
