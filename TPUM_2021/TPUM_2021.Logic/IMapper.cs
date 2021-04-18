using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.Logic
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(
            TSource realObject, 
            TDestination dtoObject = default, 
            Dictionary<object, object> alreadyInitializedObjects = null, 
            bool shouldMapInnerEntities = true) 
            where TSource : class, new() 
            where TDestination : class, new();
    }
}
