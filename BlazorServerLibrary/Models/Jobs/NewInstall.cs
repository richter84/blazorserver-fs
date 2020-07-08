using BlazorServerLibrary.Interfaces;
using BlazorServerLibrary.Models.Doors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorServerLibrary.Models.Jobs
{
    public class NewInstall : Job
    {
        //[RegularExpression("^[a-zA-Z]+-[a-zA-Z]+$", ErrorMessage = "Serial Number format invalid")]
        public override string SerialNumber { get; set; }

        [Required]
        public override Door Door { get; set; }
    }
}
