using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Interfaces
{
    public interface IRollerShutter : IDoor
    {
        string AngleCutSize { get; set; }
        string AngleType { get; set; }
        AntiFallSafety AntiFallSafety { get; set; }
        string BGSize { get; set; }
        bool Canopy { get; set; }
        string CanopyType { get; set; }
        string CanopyCutSize { get; set; }
        string CurtainType { get; set; }
        ElectricOperation ElectricOperation { get; set; }
        string FHSize { get; set; }
        bool Fascia { get; set; }
        string FasciaType { get; set; }
        string FasciaSize { get; set; }
        FireDefence FireDefence { get; set; }
        string GuideCutSize { get; set; }
        string GuideType { get; set; }
        bool IsBoltOnGuides { get; set; }
        double LathCutSize { get; set; }
        OperationType OperationType { get; set; }
        string TubeTypeGauge { get; set; }
        string RollerCutSize { get; set; }
        bool WicketEuroDoor { get; set; }
    }
}
