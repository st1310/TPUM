using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
{
    public class Command<TEntity, TEntityDto> : ICommand<TEntity, TEntityDto>
        where TEntity : IEntity
        where TEntityDto : class
    {
        protected IRepository _repository;
        protected IMapper _mapper;

        public Command(IRepository repository) : this(CommonLogicFactory.Mapper, repository)
        {

        }

        public Command(IMapper mapper, IRepository repository)
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

        public virtual void Update(int id, TEntityDto entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task UpdateAsync(int id, TEntityDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
