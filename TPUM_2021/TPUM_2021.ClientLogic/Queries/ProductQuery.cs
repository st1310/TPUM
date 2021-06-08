using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.ClientData;

[assembly: InternalsVisibleTo("TPUM_2021.ClientTest")]

namespace TPUM_2021.ClientLogic
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

        public async Task<IEnumerable<ProductDto>> GetAvailableProductsAsync()
        {
            IEnumerable<IProduct> products = await _repository.GetAsync<IProduct>(x => x.CustomerId == null || x.CustomerId == 0);

            return products.Select(x => _mapper.Map<IProduct, ProductDto>(x)).ToList();
        }

        public async Task<IEnumerable<ProductDto>> GetProductsByCustomerIdAsync(int id)
        {
            IEnumerable<IProduct> products = await _repository.GetAsync<IProduct>(x => x.CustomerId == id);

            return products.Select(x => _mapper.Map<IProduct, ProductDto>(x)).ToList();
        }
    }
}
