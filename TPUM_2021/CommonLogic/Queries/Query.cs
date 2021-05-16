using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonData;

namespace TPUM_2021.CommonLogic
{
    public class Query<TEntity, TEntityDto> : IQuery<TEntity, TEntityDto>
        where TEntity : IEntity
        where TEntityDto : class, new()
    {
        protected IRepository _repository;
        protected IMapper _mapper;

        public Query(IRepository repository) : this(CommonLogicFactory.Mapper, repository)
        {

        }

        public Query(IMapper mapper, IRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual IEnumerable<TEntityDto> GetAll()
        {
            IEnumerable<TEntity> entities = _repository.Get<TEntity>();

            return entities.Select(x => _mapper.Map<TEntity, TEntityDto>(x)).ToList();
        }

        public virtual async Task<IEnumerable<TEntityDto>> GetAllAsync()
        {
            IEnumerable<TEntity> entities = await _repository.GetAsync<TEntity>();

            return entities.Select(x => _mapper.Map<TEntity, TEntityDto>(x)).ToList();
        }

        public virtual TEntityDto GetById(object id)
        {
            TEntity entity = _repository.GetById<TEntity>(id);

            return _mapper.Map<TEntity, TEntityDto>(entity);
        }
    }
}
