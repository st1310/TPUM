using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.CommonData;

namespace TPUM_2021.CommonLogic
{
    public interface IProductQuery : IQuery<IProduct, ProductDto>
    {
        IEnumerable<ProductDto> GetAvailableProducts();
        IEnumerable<ProductDto> GetProductsByCustomerId(int id);
    }
}
