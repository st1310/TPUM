using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TPUM_2021.ClientData;

namespace TPUM_2021.ClientLogic
{
    public class Mapper : IMapper
    {
        public Mapper()
        {
            MappingTypes = new Dictionary<object, object>();
            CreateMap<ICustomer, CustomerDto>();
            //CreateMap<CustomerDto, ICustomer>();

            CreateMap<IProduct, ProductDto>();
            CreateMap<ICustomer, CustomerDto>();
        }

        public Dictionary<object, object> MappingTypes { get; set; }

        public void CreateMap<TSource, TDestination>()
            //where TSource : new()
            where TDestination : new()
        {
            if (!MappingTypes.ContainsKey(typeof(TSource)))
            {
                MappingTypes.Add(typeof(TSource), typeof(TDestination));
            }
        }

        public TDestination Map<TSource, TDestination>(
            TSource realObject, TDestination dtoObject = null,
            Dictionary<object, object> alreadyInitializedObjects = null,
            bool shouldMapInnerEntities = true)
            where TSource : IEntity//, new()
            where TDestination : class, new()
        {
            if (realObject == null)
            {
                return null;
            }
            if (alreadyInitializedObjects == null)
            {
                alreadyInitializedObjects = new Dictionary<object, object>();
            }
            if (dtoObject == null)
            {
                dtoObject = new TDestination();
            }
            var realObjectType = realObject.GetType();
            PropertyInfo[] properties = realObjectType.GetProperties();
            foreach (PropertyInfo currentRealProperty in properties)
            {
                PropertyInfo currentDtoProperty = dtoObject.GetType().GetProperty(currentRealProperty.Name);
                if (currentDtoProperty != null)
                {
                    if (MappingTypes.ContainsKey(currentRealProperty.PropertyType) && shouldMapInnerEntities)
                    {
                        object mapToObject = MappingTypes[currentRealProperty.PropertyType];
                        var types = new Type[] { currentRealProperty.PropertyType, (Type)mapToObject };
                        MethodInfo method = GetType().GetMethod("Map").MakeGenericMethod(types);
                        var realObjectPropertyValue = currentRealProperty.GetValue(realObject, null);
                        var objects = new object[]
                        {
                            realObjectPropertyValue,
                            null,
                            alreadyInitializedObjects,
                            shouldMapInnerEntities
                        };
                        if (objects != null && realObjectPropertyValue != null)
                        {
                            if (alreadyInitializedObjects.ContainsKey(realObjectPropertyValue) && currentDtoProperty.CanWrite)
                            {
                                // Set the cached version of the same object (optimization)
                                currentDtoProperty.SetValue(dtoObject, alreadyInitializedObjects[realObjectPropertyValue]);
                            }
                            else
                            {
                                // Add the object to cached objects collection.
                                alreadyInitializedObjects.Add(realObjectPropertyValue, null);
                                // Recursively call Map method again to get the new proxy object.
                                var newProxyProperty = method.Invoke(this, objects);
                                if (currentDtoProperty.CanWrite)
                                {
                                    currentDtoProperty.SetValue(dtoObject, newProxyProperty);
                                }
                                if (alreadyInitializedObjects.ContainsKey(realObjectPropertyValue) && alreadyInitializedObjects[realObjectPropertyValue] == null)
                                {
                                    alreadyInitializedObjects[realObjectPropertyValue] = newProxyProperty;
                                }
                            }
                        }
                        else if (realObjectPropertyValue == null && currentDtoProperty.CanWrite)
                        {
                            // If the original value of the object was null set null to the destination property.
                            currentDtoProperty.SetValue(dtoObject, null);
                        }
                    }
                    else if (!MappingTypes.ContainsKey(currentRealProperty.PropertyType))
                    {
                        // If the property is not custom type just set normally the value.
                        if (currentDtoProperty.CanWrite)
                        {
                            currentDtoProperty.SetValue(dtoObject, currentRealProperty.GetValue(realObject, null));
                        }
                    }
                }
            }

            return dtoObject;
        }
    }
}
