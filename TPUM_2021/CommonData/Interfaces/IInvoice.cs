using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.CommonData
{
    public interface IInvoice : IEntity
    {
        int ProductId { get; set; }
        int CustomerId { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
