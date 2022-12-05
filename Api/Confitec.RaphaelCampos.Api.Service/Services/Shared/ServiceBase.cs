using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Persistence.Interfaces.Repositories.Shared;
using Confitec.RaphaelCampos.Api.Service.Interfaces.Services.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Confitec.RaphaelCampos.Api.Service.Services.Shared
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase) => _repositoryBase = repositoryBase;

        public Task<object> AddAsync(TEntity obj) => _repositoryBase.AddAsync(obj);

        public Task DeleteAsync(TEntity obj) => _repositoryBase.DeleteAsync(obj);

        public Task DeleteByIdAsync(int id) => _repositoryBase.DeleteByIdAsync(id);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Task<IEnumerable<TEntity>> GetAllAsync() => _repositoryBase.GetAllAsync();

        public Task<TEntity> GetByIdAsync(int id) => _repositoryBase.GetByIdAsync(id);

        public Task UpdateAsync(TEntity obj) => _repositoryBase.UpdateAsync(obj);

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _repositoryBase != null)
            {
                _repositoryBase.Dispose();
            }
        }
    }
}
