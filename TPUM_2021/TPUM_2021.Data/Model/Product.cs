using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.Data.Model
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CustomerId { get; set; }
    }
}
