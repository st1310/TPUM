using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPUM_2021.CommonData;
using TPUM_2021.CommonLogic;
using TPUM_2021.ServerData;

namespace TPUM_2021.ServerLogic
{
    public class ProductQuery : Query<IProduct, ProductDto>, IProductQuery
    {
        public ProductQuery() : base(DataFactory.ProductRepository)
        {

        }

        public ProductQuery(IMapper mapper, IRepository repository) : base(mapper, repository)
        {

        }

        public IEnumerable<ProductDto> GetAvailableProducts()
        {
            IEnumerable<IProduct> products = _repository.Get<IProduct>(x => x.CustomerId == null || x.CustomerId == 0);

            return products.Select(x => _mapper.Map<IProduct, ProductDto>(x)).ToList();
        }

        public IEnumerable<ProductDto> GetProductsByCustomerId(int id)
        {
            IEnumerable<IProduct> products = _repository.Get<IProduct>(x => x.CustomerId == id);

            return products.Select(x => _mapper.Map<IProduct, ProductDto>(x)).ToList();
        }
    }
}
