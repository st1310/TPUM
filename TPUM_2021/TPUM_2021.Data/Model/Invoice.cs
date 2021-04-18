using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.Data.Model
{
    public class Invoice : Entity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
