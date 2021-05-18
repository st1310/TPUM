using System;
using System.Collections.Generic;
using System.Text;
using TPUM_2021.CommonData;

namespace TPUM_2021.CommonLogic
{
    public interface IProductCommand : ICommand<IProduct, ProductDto>
    {
    }
}
