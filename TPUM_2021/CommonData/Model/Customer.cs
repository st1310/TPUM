using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("TPUM_2021.ServerData")]
[assembly: InternalsVisibleTo("TPUM_2021.ClientData")]

namespace TPUM_2021.CommonData.Model
{
    internal class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Funds { get; set; }
    }
}
