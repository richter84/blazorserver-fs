using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Repair : Job
    {
        public override string SerialNumber { get; set; }
        public override Door Door { get; set; }
    }
}
