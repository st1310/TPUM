using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.Data.Model;

namespace TPUM_2021.Logic
{
    public interface IProductQuery : IQuery<Product, ProductDto>
    {
        IEnumerable<ProductDto> GetAvailableProducts();
        IEnumerable<ProductDto> GetProductsByCustomerId(int id);
    }
}
