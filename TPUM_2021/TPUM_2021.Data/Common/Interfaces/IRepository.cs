using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TPUM_2021.Data
{
    public interface IRepository
    {
        void Delete<TEntity>(TEntity entity) where TEntity : IEntity;
        void Delete<TEntity>(object id) where TEntity : IEntity;
        IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null) where TEntity : IEntity;
        TEntity GetById<TEntity>(object id) where TEntity : IEntity;
        void Insert<TEntity>(TEntity entity) where TEntity : IEntity;
        void InsertRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : IEntity;
        Type GetEntityType<TEntity>() where TEntity : IEntity;
    }
}
