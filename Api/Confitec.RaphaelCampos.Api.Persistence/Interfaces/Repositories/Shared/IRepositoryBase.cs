using Confitec.RaphaelCampos.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Confitec.RaphaelCampos.Api.Persistence.Interfaces.Repositories.Shared
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<object> AddAsync(TEntity obj);

        Task UpdateAsync(TEntity obj);

        Task DeleteAsync(TEntity obj);

        Task DeleteByIdAsync(int id);
    }
}
