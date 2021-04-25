using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data;

namespace TPUM_2021.Logic
{
    public interface IProductQuery : IQuery<IProduct, ProductDto>
    {
        IEnumerable<ProductDto> GetAvailableProducts();
        IEnumerable<ProductDto> GetProductsByCustomerId(int id);
    }
}
