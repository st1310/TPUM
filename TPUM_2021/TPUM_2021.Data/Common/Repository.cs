using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TPUM_2021.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly AppContext _context;
        private readonly Type _entityType;
        private static object _lock = new object();

        public Repository(AppContext context)
        {
            _context = context;
            _entityType = typeof(TEntity);
        }

        public virtual void Delete(TEntity entity)
        {
            lock (_lock)
            {
                ((List<TEntity>)_context[_entityType]).Remove(entity);
            }
        }

        public virtual void Delete(object id)
        {
            lock (_lock)
            {
                TEntity entity = ((List<TEntity>)_context[_entityType]).First(x => x.Id == (int)id);
                ((List<TEntity>)_context[_entityType]).Remove(entity);
            }
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            lock (_lock)
            {
                IQueryable<TEntity> entities = ((List<TEntity>)_context[_entityType]).AsQueryable();

                if (filter != null)
                    entities.Where(filter);

                return entities;
            }
        }

        public virtual TEntity GetById(object id)
        {
            lock (_lock)
            {
                return ((List<TEntity>)_context[_entityType]).First(x => x.Id == (int)id);
            }
        }

        public virtual void Insert(TEntity entity)
        {
            lock (_lock)
            {
                ((List<TEntity>)_context[_entityType]).Add(entity);
            }
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            lock (_lock)
            {
                ((List<TEntity>)_context[_entityType]).AddRange(entities);
            }
        }
    }
}
