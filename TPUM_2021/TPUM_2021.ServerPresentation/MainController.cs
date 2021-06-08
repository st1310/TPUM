using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonLogic;
using TPUM_2021.CommonWebSocketApi;
using TPUM_2021.OPCUAdependencies.Model;
using TPUM_2021.ServerLogic;

namespace TPUM_2021.ServerPresentation
{
    public class MainController : BaseController
    {
        public IProductQuery _ProductQuery;
        public ICustomerQuery _CustomerQuery;

        public IProductCommand _ProductCommand;

        public MainController(int p2p_port = 8081) : base(p2p_port)
        {
            _ProductQuery = LogicFactory.ProductQuery;
            _CustomerQuery = LogicFactory.CustomerQuery;
            _ProductCommand = LogicFactory.ProductCommand;
        }

        public override string Resolve(string data)
        {
            string[] parameters = data.Split(':');

            if (parameters[0].Equals("Customer"))
            {
                if (parameters[1].Equals("Get") && parameters[2].Equals(string.Empty))
                {
                    List<CustomerS> customers = new List<CustomerDto>(_CustomerQuery.GetAll()).Select(x => Map<CustomerDto>(x) as CustomerS).ToList();

                    return Serialize(typeof(List<CustomerS>), customers);
                }
            }

            if (parameters[0].Equals("Product"))
            {
                if (parameters[1].Equals("Get") && parameters[2].Equals(string.Empty))
                {
                    List<ProductS> customers = new List<ProductDto>(_ProductQuery.GetAll()).Select(x => Map<ProductDto>(x) as ProductS).ToList();

                    return Serialize(typeof(List<ProductS>), customers);
                }

                //if (parameters[1].Equals("GetAvailable"))
                //{
                //    List<ProductDto> products = new List<ProductDto>(_ProductQuery.GetAvailableProducts());

                //    return Serialize(typeof(List<ProductDto>), products);
                //}
                
                //if (parameters[1].Equals("GetByCustomerId"))
                //{
                //    List<ProductDto> products = new List<ProductDto>(_ProductQuery.GetProductsByCustomerId(int.Parse(parameters[2])));

                //    return Serialize(typeof(List<ProductDto>), products);
                //}

                if (parameters[1].Equals("Update"))
                {
                    _ProductCommand.Update(int.Parse(parameters[2]),
                        Map<ProductS>(Deserialize<ProductS>(data.Replace($"{parameters[0]}:{parameters[1]}:{parameters[2]}:", ""))) as ProductDto);

                    return string.Empty;
                }

                if (parameters[1].Equals("Delete"))
                {
                    _ProductCommand.Delete(Map<ProductS>(Deserialize<ProductS>(data.Replace($"{parameters[0]}:{parameters[1]}:", ""))) as ProductDto);

                    return string.Empty;
                }

                if (parameters[1].Equals("Insert"))
                {
                    _ProductCommand.Insert(Map<ProductS>(Deserialize<ProductS>(data.Replace($"{parameters[0]}:{parameters[1]}:", ""))) as ProductDto);

                    return string.Empty;
                }
            }

            throw new ArgumentOutOfRangeException();
        }

        private string Serialize(Type type, object obj)
        {
            using MemoryStream stream = new MemoryStream();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(type);
            serializer.WriteObject(stream, obj);

            byte[] json = stream.ToArray();

            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        // Will throw an exception if deserialization fails
        private TOut Deserialize<TOut>(string data) where TOut: class
        {
            using MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TOut));

            return serializer.ReadObject(stream) as TOut;
        }

        private object Map<TIn>(object obj)
        {
            if (typeof(TIn) == typeof(CustomerDto))
            {
                CustomerDto tmp = obj as CustomerDto;
                return new CustomerS
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    Funds = tmp.Funds
                };
            }
            
            if(typeof(TIn) == typeof(ProductDto))
            {
                ProductDto tmp = obj as ProductDto;
                return new ProductS
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    CustomerId = tmp.CustomerId,
                    Price = tmp.Price
                };
            }

            if (typeof(TIn) == typeof(CustomerS))
            {
                CustomerS tmp = obj as CustomerS;
                return new CustomerDto
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    Funds = tmp.Funds
                };
            }

            if (typeof(TIn) == typeof(ProductS))
            {
                ProductS tmp = obj as ProductS;
                return new ProductDto
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    CustomerId = tmp.CustomerId,
                    Price = tmp.Price
                };
            }

            throw new ArgumentOutOfRangeException();
        }

        public override void Dispose()
        {
            Task.WaitAll(Sockets.Select(x => x.DisconnectAsync()).ToArray());
        }
    }
}
