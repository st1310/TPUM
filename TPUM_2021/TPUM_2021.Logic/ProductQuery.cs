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
        public ProductQuery() : base()
        {

        }

        public ProductQuery(IMapper mapper, IRepository<Product> repository) : base(mapper, repository)
        {

        }

        public IEnumerable<ProductDto> GetAvailableProducts()
        {
            IEnumerable<Product> products = _repository.Get(x => x.CustomerId == null || x.CustomerId == 0);

            return products.Select(x => _mapper.Map<Product, ProductDto>(x)).ToList();
        }

        public IEnumerable<ProductDto> GetProductsByCustomerId(int id)
        {
            IEnumerable<Product> products = _repository.Get(x => x.CustomerId == id);

            return products.Select(x => _mapper.Map<Product, ProductDto>(x)).ToList();
        }
    }
}
