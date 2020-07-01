using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface INewInstall<TEntity> : IService<TEntity> where TEntity : NewInstall
    {
        Task<List<NewInstall>> GetNewInstalls(int customerId);
        Task<NewInstall> GetNewInstall(int Id);
    }
}
