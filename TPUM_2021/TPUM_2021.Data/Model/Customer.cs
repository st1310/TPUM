using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.Data.Model
{
    internal class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Funds { get; set; }
    }
}
