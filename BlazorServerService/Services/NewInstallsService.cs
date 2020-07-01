using BlazorServerLibrary.Models;
using BlazorServerService.Data;
using BlazorServerService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Services
{
    public class NewInstallsService<TEntity> : INewInstall<TEntity> where TEntity : NewInstall
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
            return await _context.NewInstalls
                .Include(n => n.Door)
                .Include(n => n.Customer)
                .FirstOrDefaultAsync(n => n.Id == Id);
        }

        public async Task<List<NewInstall>> GetNewInstalls(int customerId)
        {
            return await _context.NewInstalls
                .Where(n => n.Customer.Id == customerId)
                .OrderBy(n => n.Id)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
