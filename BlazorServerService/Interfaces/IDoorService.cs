using BlazorServerLibrary.Models.Doors;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerService.Interfaces
{
    public interface IDoorService
    {
        RollerShutterDoor GetRollerShutterDoorById(int id);
    }
}
