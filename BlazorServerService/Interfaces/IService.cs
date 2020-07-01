using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerService.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<TEntity> AddorUpdate(TEntity entityType);
        Task<TEntity> Archive(TEntity entityType);
        Task<TEntity> Delete(TEntity entityType);
    }
}
