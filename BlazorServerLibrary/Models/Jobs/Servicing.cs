using BlazorServerLibrary.Models.Doors;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Models.Jobs
{
    public class Servicing : Job
    {
        public override string SerialNumber { get; set; }
        public override Door Door { get; set; }
    }
}
