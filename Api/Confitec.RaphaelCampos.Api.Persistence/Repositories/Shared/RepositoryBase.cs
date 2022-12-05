using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Domain.Shared;
using Confitec.RaphaelCampos.Api.Persistence.Context;
using Confitec.RaphaelCampos.Api.Persistence.Interfaces.Repositories.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Confitec.RaphaelCampos.Api.Persistence.Repositories.Shared
{
    [ExcludeFromCodeCoverage]
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public virtual async Task<object> AddAsync(TEntity obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public virtual async Task DeleteAsync(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteByIdAsync(int id)
        {
            var obj = await GetByIdAsync(id);
            if(obj == null)
            {
                throw new ArgumentException(Constants.OBJECT_NOT_FOUND, id.ToString());
            }
            await DeleteAsync(obj);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _context != null)
            {
                _context.Dispose();
            }
        }
    }
}
