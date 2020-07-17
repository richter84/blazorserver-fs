using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum ElectricalSafety
    {
        [Display(Name = "Safety Edge")]
        SafetyEdge = 1,
        [Display(Name = "P.E.C")]
        PEC = 2,
        [Display(Name = "Wired Brake")]
        WiredBrake = 3,
        Interlock = 4
    }
}
