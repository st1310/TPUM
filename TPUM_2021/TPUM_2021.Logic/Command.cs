using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class Command<TEntity, TEntityDto> : ICommand<TEntity, TEntityDto> where TEntity : Entity
    {
        IRepository<TEntity> _repository;

        public Command(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Delete(TEntityDto entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(TEntityDto entity)
        {
            throw new NotImplementedException();
        }

        public virtual void InsertRange(IEnumerable<TEntityDto> entities)
        {
            throw new NotImplementedException();
        }
    }
}
