using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("TPUM_2021.Test")]

namespace TPUM_2021.Data.Model
{
    internal class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CustomerId { get; set; }
    }
}
