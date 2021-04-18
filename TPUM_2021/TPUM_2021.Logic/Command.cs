using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class Command<TEntity> : ICommand<TEntity> where TEntity : Entity
    {
        IRepository<TEntity> _repository;

        public Command(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void InsertRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
