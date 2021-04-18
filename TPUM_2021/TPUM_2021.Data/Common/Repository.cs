using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TPUM_2021.Data.Common
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly AppContext _context;
        private readonly Type _entityType;

        public Repository(AppContext context)
        {
            _context = context;
            _entityType = typeof(TEntity);
        }

        public virtual void Delete(TEntity entity)
        {
            ((List<TEntity>)_context[_entityType]).Remove(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entity = ((List<TEntity>)_context[_entityType]).First(x => x.Id == (int)id);
            ((List<TEntity>)_context[_entityType]).Remove(entity);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> entities = ((List<TEntity>)_context[_entityType]).AsQueryable();

            if (filter != null)
                entities.Where(filter);

            return entities;
        }

        public virtual TEntity GetById(object id)
        {
            return ((List<TEntity>)_context[_entityType]).First(x => x.Id == (int)id);
        }

        public virtual void Insert(TEntity entity)
        {
            ((List<TEntity>)_context[_entityType]).Add(entity);
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            ((List<TEntity>)_context[_entityType]).AddRange(entities);
        }
    }
}
