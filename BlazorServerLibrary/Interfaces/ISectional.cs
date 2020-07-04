using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    interface ISectional
    {
        AntiFallSafety AntiFallSafety { get; set; }
        double Cable { get; set; }
        ElectricOperation ElectricOperation { get; set; }
        string LiftType { get; set; }
        int NumberOfSprings { get; set; }
        OperationType OperationType { get; set; }
        double OverJambSize { get; set; }
        double PanelOECSize { get; set; }
        double ShaftSize { get; set; }
        double ShaftLength { get; set; }
        double SizeToSpringAssembly { get; set; }
        double SpringSize { get; set; }
        double SpringLength { get; set; }
        double TopOfTrackSize { get; set; }
        bool WicketEuroDoor { get; set; }
    }
}
