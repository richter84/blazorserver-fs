using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerService.Interfaces
{
    public interface IDoorService
    {
        RollerShutter GetRollerShutterDoorById(int id);
    }
}
