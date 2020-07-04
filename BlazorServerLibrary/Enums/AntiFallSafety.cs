using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum AntiFallSafety
    {
        [Display(Name = "Not Applicable")]
        NA = 1,
        [Display(Name = "Spring As Brake")]
        SpringAsBrake = 2,
        [Display(Name = "Safety Brake")]
        SafetyBrake = 3,
        [Display(Name = "Safe Drive")]
        SafeDrive = 4
    }
}
