using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum OperationType
    {
        Electric = 1,
        [Display(Name = "Manual - Chain")]
        ManualChain = 2,
        [Display(Name = "Manual - Push Up Pull Down")]
        ManualPushUpDown = 3
    }
}
