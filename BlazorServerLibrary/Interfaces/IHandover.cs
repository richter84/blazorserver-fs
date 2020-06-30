using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    interface IHandover
    {
        bool Demonstration { get; set; }
        bool ServiceScheduleLog { get; set; }
        bool ControlsIfApplicable { get; set; }
        bool SafetyDevicesExplained { get; set; }
        bool PointOfContactName { get; set; }
        string PointOfContactSignature { get; set; }
        bool IsCompleteByEngineer { get; set; }
    }
}
