﻿using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public interface ICommand<TEntity, TEntityDto>
        where TEntity : IEntity
        where TEntityDto : class
    {
        void Delete(TEntityDto entity);
        void Insert(TEntityDto entity);
        void InsertRange(IEnumerable<TEntityDto> entities);
        void Update(int id, TEntityDto entity);
    }
}