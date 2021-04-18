using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class Command<TEntity, TEntityDto> : ICommand<TEntity, TEntityDto>
        where TEntity : Entity, new()
        where TEntityDto : class, new()
    {
        protected IRepository<TEntity> _repository;
        protected IMapper _mapper;

        public Command() : this(DependencyResolver.Mapper, new Repository<TEntity>(DependencyResolver.Context))
        {

        }

        public Command(IMapper mapper, IRepository<TEntity> repository)
        {
            _repository = repository;
            _mapper = mapper;
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
