using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ClientLogic
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CustomerId { get; set; }
    }
}
