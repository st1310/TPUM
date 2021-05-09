using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TPUM_2021.CommonData;

[assembly: InternalsVisibleTo("TPUM_2021.Test")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace TPUM_2021.ClientData
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
                string message = _context.GetTypeName(typeof(TEntity));
                message += ":Delete:";
                message += _context.Serialize(typeof(TEntity), entity);

                _context.SendAsync(message).Wait();
            }
        }

        public virtual void Delete<TEntity>(object id) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null) where TEntity : IEntity
        {
            lock (_lock)
            {
                var promise = new TaskCompletionSource<string>();
                RepositoryObserver observer = new RepositoryObserver();
                observer.onMessage = data => promise.TrySetResult(data);
                observer.Subscribe(_context);

                promise.Task.Wait();

                IQueryable<TEntity> entities = _context.DeserializeList<TEntity>(promise.Task.Result).AsQueryable();
                if (filter != null)
                    return entities.Where(filter);

                return _context.DeserializeList<TEntity>(promise.Task.Result);
            }
        }

        public virtual TEntity GetById<TEntity>(object id) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual void Insert<TEntity>(TEntity entity) where TEntity : IEntity
        {
            lock (_lock)
            {
                string message = _context.GetTypeName(typeof(TEntity));
                message += ":Insert:";
                message += _context.Serialize(typeof(TEntity), entity);

                _context.SendAsync(message).Wait();
            }
        }

        public virtual void InsertRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual Type GetEntityType<TEntity>() where TEntity : IEntity
        {
            return typeof(TEntity);
        }
    }
}
