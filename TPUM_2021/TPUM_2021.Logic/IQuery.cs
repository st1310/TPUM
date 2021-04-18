﻿using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public interface IQuery<TEntity, TEntityDto>
        where TEntity : Entity, new()
        where TEntityDto : class, new()
    {
        IEnumerable<TEntityDto> GetAll();
        TEntityDto GetById(object id);
    }
}
