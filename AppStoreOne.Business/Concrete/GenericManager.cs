using AppStoreOne.Business.Interfaces;
using AppStoreOne.DataAccess.Concrete.UOW;
using AppStoreOne.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppStoreOne.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IUnitOfWork _uow;

        public GenericManager(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task AddAsync(TEntity entity)
        {
            await _uow.GetRepository<TEntity>().AddAsync(entity);
            await _uow.SaveChanges();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await _uow.GetRepository<TEntity>().FindByIdAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _uow.GetRepository<TEntity>().GetAllAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _uow.GetRepository<TEntity>().GetAllAsync(filter);
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            return await _uow.GetRepository<TEntity>().GetAllAsync(filter, keySelector);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _uow.GetRepository<TEntity>().GetAsync(filter);
        }

        public async Task<TEntity> GetNoTrackingAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _uow.GetRepository<TEntity>().GetNoTrackingAsync(filter);
        }

        public async Task Remove(TEntity entity)
        {
            _uow.GetRepository<TEntity>().Remove(entity);
            await _uow.SaveChanges();
        }

        public async Task Update(TEntity entity)
        {
            _uow.GetRepository<TEntity>().Update(entity);
            await _uow.SaveChanges();
        }
    }
}
