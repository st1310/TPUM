using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TPUM_2021.Data.Model;

[assembly: InternalsVisibleTo("TPUM_2021.Test")]

namespace TPUM_2021.Data
{
    internal class AppContext
    {
        private readonly Dictionary<Type, IEnumerable<IEntity>> typeListPairs;

        public AppContext()
        {
            typeListPairs = new Dictionary<Type, IEnumerable<IEntity>>
            {
                { 
                    typeof(ICustomer), new List<ICustomer> 
                    { 
                        new Customer { Id = 1,Name = "Karol", Funds = 400 } 
                    } 
                },
                { 
                    typeof(IProduct), new List<IProduct> 
                    { 
                        new Product { Id = 1, Name = "product1", Price = 10 , CustomerId = null }, 
                        new Product { Id = 2, Name = "product2", Price = 20 , CustomerId = 1 } 
                    } 
                },
                { 
                    typeof(IInvoice), new List<IInvoice>() 
                }
            };
        }

        public IEnumerable<IEntity> this[Type type]
        {
            get => typeListPairs[type];
            set => typeListPairs[type] = value;
        }
    }
}
