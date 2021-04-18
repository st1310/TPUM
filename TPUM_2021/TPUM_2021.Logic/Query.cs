using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class Query<TEntity, TEntityDto> : IQuery<TEntity, TEntityDto> where TEntity : Entity
    {
        IRepository<TEntity> _repository;

        public Query(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<TEntityDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual TEntityDto GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
