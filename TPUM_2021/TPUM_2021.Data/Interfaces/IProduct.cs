using System;
using System.Collections.Generic;
using System.Text;

namespace TPUM_2021.ServerData
{
    public interface IProduct : IEntity
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int? CustomerId { get; set; }
    }
}
