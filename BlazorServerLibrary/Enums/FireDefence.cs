using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Enums
{
    public enum FireDefence
    {
        None = 1,
        [Display(Name = "Thirty Minute Rated")]
        ThirtyMinuteRated = 2,
        [Display(Name = "One Hour Rated")]
        OneHourRated = 3,
        [Display(Name = "Two Hour Rated")]
        TwoHourRated = 4,
        [Display(Name = "Four Hour Rated")]
        FourHourRated = 5
    }
}
