using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public class Query<TEntity, TEntityDto> : IQuery<TEntity, TEntityDto>
        where TEntity : Entity, new()
        where TEntityDto : class, new()
    {
        protected IRepository<TEntity> _repository;
        protected IMapper _mapper;

        public Query() : this(DependencyResolver.Mapper, new Repository<TEntity>(DependencyResolver.Context))
        {

        }

        public Query(IMapper mapper, IRepository<TEntity> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual IEnumerable<TEntityDto> GetAll()
        {
            IEnumerable<TEntity> entities = _repository.Get();

            return entities.Select(x => _mapper.Map<TEntity, TEntityDto>(x)).ToList();
        }

        public virtual TEntityDto GetById(object id)
        {
            TEntity entity = _repository.GetById(id);

            return _mapper.Map<TEntity, TEntityDto>(entity);
        }
    }
}
