using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum ElectricalSafety
    {
        All = 1,
        [Display(Name = "Safety Edge")]
        SafetyEdge = 2,
        [Display(Name = "P.E.C")]
        PEC = 3,
        [Display(Name = "Wired Brake")]
        WiredBrake = 4,
        Interlock = 5
    }
}
