using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public interface IQuery<TEntity> where TEntity: Entity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
    }
}
