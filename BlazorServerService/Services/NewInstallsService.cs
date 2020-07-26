using BlazorServerLibrary.Models;
using BlazorServerLibrary.Models.Jobs;
using BlazorServerLibrary.Enums;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerLibrary.Models.Doors;
using Microsoft.EntityFrameworkCore.Internal;

namespace BlazorServerService.Services
{
    public class NewInstallsService<TEntity> : INewInstallService<TEntity> where TEntity : NewInstall
    {
        private readonly DataContext _context;
        public NewInstallsService(DataContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddorUpdate(TEntity newInstall)
        {
            var existingJob = await _context.NewInstalls.FindAsync(newInstall.Id);

            if (existingJob == null)
            {
                newInstall.SerialNumber = CreateSerialNumber(newInstall);
                newInstall.Status = JobStatus.Pending;
                _context.NewInstalls.Add(newInstall);
            }
            else
            {
                _context.NewInstalls.Update(existingJob);
            }

            await _context.SaveChangesAsync();
            return newInstall;
        }

        public Task<TEntity> Archive(TEntity entityType)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Delete(TEntity entityType)
        {
            throw new NotImplementedException();
        }

        public async Task<NewInstall> GetNewInstall(int Id)
        {
            IQueryable<NewInstall> query = _context.NewInstalls
                .Include(n => n.Door)
                .Include(n => n.Customer)
                .Include(n => n.Handover)
                .Include(n => n.History)
                .Where(n => n.Id == Id);

            var q = _context.Doors.Where(d => d.JobId == Id)
                .OfType<RollerShutterDoor>()
                .Include(r => r.ElectricOperation)
                .ThenInclude(e => e.ElectricalSafety);



            var w = q.FirstOrDefault();

            //var door = query.OfType<RollerShutterDoor>();
            //var s = door.FirstOrDefault();

            query = query;


            //.Include(r => r.ElectricOperation).ThenInclude(e => e.ElectricalSafety);

            var result = await query.FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<NewInstall>> GetNewInstalls(int customerId)
        {
            return await _context.NewInstalls
                .Where(n => n.Customer.Id == customerId)
                .OrderBy(n => n.Id)
                .AsNoTracking()
                .ToListAsync();
        }

        private string CreateSerialNumber(NewInstall newInstall)
        {
            int jobNumber = _context.NewInstalls.Where(n => n.Customer.Id == newInstall.Customer.Id).Count();
            return $"{newInstall.Customer.Name.ToUpper().Substring(0, 4)}-{DateTime.Now:yyyy-MM}-{++jobNumber:0000}";
        }
    }
}
