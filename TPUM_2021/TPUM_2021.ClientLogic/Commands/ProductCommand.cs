using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPUM_2021.ClientData;
using TPUM_2021.CommonData;
using TPUM_2021.CommonLogic;
using TPUM_2021.ServerData;

namespace TPUM_2021.ClientLogic
{
    public class ProductCommand : Command<IProduct, ProductDto>, IProductCommand
    {
        public ProductCommand() : base(DataFactory.ProductRepository)
        {

        }

        public override void Update(int id, ProductDto entity)
        {
            IProduct obj = _repository.Get<IProduct>(x => x.Id == id).FirstOrDefault();

            _repository.Delete(obj);

            var product = DataFactory.GetProduct;
            product.Id = entity.Id;
            product.Name = entity.Name;
            product.Price = entity.Price;
            product.CustomerId = entity.CustomerId;

            _repository.Insert(product);
        }
    }
}
