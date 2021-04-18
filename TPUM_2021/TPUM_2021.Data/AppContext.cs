using System;
using System.Collections;
using System.Collections.Generic;
using TPUM_2021.Data.Model;

namespace TPUM_2021.Data
{
    public class AppContext
    {
        private readonly Dictionary<Type, IEnumerable<object>> typeListPairs;

        public AppContext()
        {
            typeListPairs = new Dictionary<Type, IEnumerable<object>>
            {
                { typeof(Customer), new List<Customer> 
                    { 
                        new Customer { Id = 1,Name = "Karol", Funds = 400 } 
                    } 
                },
                { typeof(Product), new List<Product> 
                    { 
                        new Product { Id = 1, Name = "product1", Price = 10 , CustomerId = null }, 
                        new Product { Id = 2, Name = "product2", Price = 20 , CustomerId = 1 } 
                    } 
                },
                { typeof(Invoice), new List<Invoice>() }
            };
        }

        public IEnumerable<object> this[Type type]
        {
            get => typeListPairs[type];
            set => typeListPairs[type] = value;
        }
    }
}
