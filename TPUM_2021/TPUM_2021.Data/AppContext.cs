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
                { typeof(Customer), new List<Customer>() },
                { typeof(Product), new List<Product>() },
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
