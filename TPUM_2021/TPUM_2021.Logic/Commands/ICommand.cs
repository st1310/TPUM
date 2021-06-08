using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.ServerData;

namespace TPUM_2021.ServerLogic
{
    public interface ICommand<TEntity, TEntityDto>
        where TEntity : IEntity
        where TEntityDto : class
    {
        void Delete(TEntityDto entity);
        void Insert(TEntityDto entity);
        void InsertRange(IEnumerable<TEntityDto> entities);
        void Update(int id, TEntityDto entity);
        Task UpdateAsync(int id, TEntityDto entity);
    }
}
