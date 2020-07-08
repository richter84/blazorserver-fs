using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Handover
    {
        public int Id { get; set; }
        public bool AllControlsCleaned { get; set; }
        public bool ControlsIfApplicable { get; set; }
        public bool Demonstration { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public bool IsCompleteByEngineer { get; set; }

        [MaxLength(100)]
        public string PointOfContactName { get; set; }
        public string PointOfContactSignatureUrl { get; set; }
        public bool SafetyDevicesExplained { get; set; }
        public bool ServiceScheduleLog { get; set; }
        public DateTimeOffset? StartDate { get; set; }
    }
}
