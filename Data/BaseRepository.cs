using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreMediatRExample.Data.Context;
using NetCoreMediatRExample.Models;

namespace NetCoreMediatRExample.Data
{
    public class BaseRepository<TEntity> where TEntity : class, IBaseEntity, new()
    {
        private MediatorContext context;
        private DbSet<TEntity> dbSet;
        public BaseRepository()
        {
            this.context = new MediatorContext();
            dbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public async Task<TEntity> Update(TEntity entity)
        {
             dbSet.Update(entity);
             await context.SaveChangesAsync();
             return entity;
        }
        public async Task<TEntity> Delete(int Id)
        {
            var currentEntity = dbSet.SingleOrDefault(m => m.Id == Id);
            dbSet.Remove(currentEntity);
            await context.SaveChangesAsync();
            return currentEntity;
        }
        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await dbSet.SingleOrDefaultAsync(m => m.Id == Id);
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}
