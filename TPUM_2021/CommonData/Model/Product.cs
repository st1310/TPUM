using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("TPUM_2021.Test")]
[assembly: InternalsVisibleTo("TPUM_2021.ServerData")]
[assembly: InternalsVisibleTo("TPUM_2021.ClientData")]

namespace TPUM_2021.CommonData.Model
{
    internal class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CustomerId { get; set; }
    }
}
