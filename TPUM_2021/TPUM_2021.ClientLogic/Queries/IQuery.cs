using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
{
    public interface IQuery<TEntity, TEntityDto>
        where TEntity : IEntity
        where TEntityDto : class, new()
    {
        IEnumerable<TEntityDto> GetAll();
        Task<IEnumerable<TEntityDto>> GetAllAsync();
        TEntityDto GetById(object id);
    }
}
