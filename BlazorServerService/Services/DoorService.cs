using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Doors;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorServerService.Services
{
    public class DoorService : IDoorService
    {
        public readonly DataContext _context;

        public DoorService(DataContext context)
        {
            _context = context;
        }

        public RollerShutterDoor GetRollerShutterDoorById(int id)
        {
            var rollerShutter = _context.RollerShutters
                .Include(d => d.ElectricOperation)
                .FirstOrDefault(d => d.Id == id);

            return rollerShutter;
        }
    }
}
