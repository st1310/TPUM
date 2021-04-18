using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.Data.Model
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public decimal Funds { get; set; }
    }
}
