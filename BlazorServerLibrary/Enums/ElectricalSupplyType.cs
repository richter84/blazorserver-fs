using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum ElectricalSupplyType
    {
        [Display(Name = "1Ph")]
        OnePh = 1,
        [Display(Name = "3Ph")]
        ThreePh = 2
    }
}
