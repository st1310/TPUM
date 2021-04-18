using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPUM_2021.Data;
using TPUM_2021.Data.Model;

namespace TPUM_2021.Logic
{
    public class ProductQuery : Query<Product, ProductDto>, IProductQuery
    {
        public ProductQuery(IRepository<Product> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        public IEnumerable<ProductDto> GetAvailableProducts()
        {
            IEnumerable<Product> products = _repository.Get(x => x.CustomerId == null || x.CustomerId == 0);

            return products.Select(x => _mapper.Map<Product, ProductDto>(x));
        }

        public IEnumerable<ProductDto> GetProductsByCustomerId(int id)
        {
            IEnumerable<Product> products = _repository.Get(x => x.CustomerId == id);

            return products.Select(x => _mapper.Map<Product, ProductDto>(x));
        }
    }
}
