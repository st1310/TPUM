using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(
            TSource realObject,
            TDestination dtoObject = default,
            Dictionary<object, object> alreadyInitializedObjects = null,
            bool shouldMapInnerEntities = true)
            where TSource : IEntity//, new() 
            where TDestination : class, new();
    }
}
