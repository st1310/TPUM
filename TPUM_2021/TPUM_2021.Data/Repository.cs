using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TPUM_2021.ServerTest")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace TPUM_2021.ServerData
{
    internal class Repository : IRepository
    {
        private readonly AppContext _context;
        private static object _lock = new object();

        public Repository(AppContext context)
        {
            _context = context;
        }

        public virtual void Delete<TEntity>(TEntity entity) where TEntity : IEntity
        {
            lock (_lock)
            {
                ((List<TEntity>)_context[GetEntityType<TEntity>()]).Remove(entity);
            }
        }

        public Task DeleteAsync<TEntity>(TEntity entity) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual void Delete<TEntity>(object id) where TEntity : IEntity
        {
            lock (_lock)
            {
                TEntity entity = ((List<TEntity>)_context[GetEntityType<TEntity>()]).First(x => x.Id == (int)id);
                ((List<TEntity>)_context[GetEntityType<TEntity>()]).Remove(entity);
            }
        }

        public virtual IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null) where TEntity : IEntity
        {
            lock (_lock)
            {
                IQueryable<TEntity> entities = ((List<TEntity>)_context[GetEntityType<TEntity>()]).AsQueryable();

                if (filter != null)
                    return entities.Where(filter);

                return entities;
            }
        }

        public Task<IEnumerable<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetById<TEntity>(object id) where TEntity : IEntity
        {
            lock (_lock)
            {
                return ((List<TEntity>)_context[GetEntityType<TEntity>()]).First(x => x.Id == (int)id);
            }
        }

        public virtual void Insert<TEntity>(TEntity entity) where TEntity : IEntity
        {
            lock (_lock)
            {
                ((List<TEntity>)_context[GetEntityType<TEntity>()]).Add(entity);
            }
        }

        public Task InsertAsync<TEntity>(TEntity entity) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual void InsertRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : IEntity
        {
            lock (_lock)
            {
                ((List<TEntity>)_context[GetEntityType<TEntity>()]).AddRange(entities);
            }
        }

        public virtual Type GetEntityType<TEntity>() where TEntity : IEntity
        {
            return typeof(TEntity);
        }
    }
}
