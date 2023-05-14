using CalculationCash.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;

        public Repository(DbContext context, DbSet<TEntity> entities)
        {
            _context = context;
            _entities = entities;
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task Add(TEntity entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            TEntity entity = await GetById(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }

/*
        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }
        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
        }
        public IQueryable<TEntity> GetAll()
        {
            return entities;
        }
        public TEntity GetById(Guid id)
        {
            return entities.SingleOrDefault(e => e.Id.Equals(id));
        }
        public void Update(TEntity entity)
        {
            entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
*/
        
    }
}
