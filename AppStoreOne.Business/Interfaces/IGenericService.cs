using AppStoreOne.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppStoreOne.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetNoTrackingAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> FindByIdAsync(int id);

        Task AddAsync(TEntity entity);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
    }
}
