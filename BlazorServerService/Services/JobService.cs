using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Models.Jobs;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Services
{
    
    public class JobService : IJobService
    {
        private readonly DataContext _context;

        public JobService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<NewInstall>> GetNewInstalls()
        {
            return await _context.NewInstalls
                .Include(n => n.Customer)
                .AsTracking()
                .ToListAsync();
        }
    }
}
