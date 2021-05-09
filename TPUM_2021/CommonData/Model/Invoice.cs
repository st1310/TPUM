using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("TPUM_2021.ServerData")]
[assembly: InternalsVisibleTo("TPUM_2021.ClientData")]

namespace TPUM_2021.CommonData.Model
{
    internal class Invoice : IInvoice
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
