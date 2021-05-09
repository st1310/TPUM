using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonLogic;
using TPUM_2021.CommonWebSocketApi;

namespace TPUM_2021.ServerPresentation
{
    public class MainController : BaseController
    {
        public IProductQuery _ProductQuery;
        public ICustomerQuery _CustomerQuery;

        public IProductCommand _ProductCommand;

        public MainController(int p2p_port = 8081) : base(p2p_port)
        {

        }

        public override string Resolve(string data)
        {
            string[] parameters = data.Split(':');

            if (parameters[0].Equals("Customer"))
            {
                if (parameters[1].Equals("Get") && parameters[2].Equals(string.Empty))
                {
                    List<CustomerDto> customers = new List<CustomerDto>(_CustomerQuery.GetAll());

                    return Serialize(typeof(List<CustomerDto>), customers);
                }
            }

            if (parameters[0].Equals("Product"))
            {
                if (parameters[1].Equals("GetAvailable"))
                {
                    List<ProductDto> products = new List<ProductDto>(_ProductQuery.GetAvailableProducts());

                    return Serialize(typeof(List<ProductDto>), products);
                }
                
                if (parameters[1].Equals("GetByCustomerId"))
                {
                    List<ProductDto> products = new List<ProductDto>(_ProductQuery.GetProductsByCustomerId(int.Parse(parameters[2])));

                    return Serialize(typeof(List<ProductDto>), products);
                }

                if (parameters[1].Equals("Update"))
                {
                    _ProductCommand.Update(int.Parse(parameters[2]), Deserialize<ProductDto>(data));

                    return string.Empty;
                }
            }

            throw new NotImplementedException();
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

        public override void Dispose()
        {
            Task.WaitAll(Sockets.Select(x => x.DisconnectAsync()).ToArray());
        }
    }
}
