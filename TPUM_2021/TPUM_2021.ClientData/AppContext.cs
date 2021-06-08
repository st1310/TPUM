using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonWebSocketApi;
using TPUM_2021.OPCUAdependencies.Model;

[assembly: InternalsVisibleTo("TPUM_2021.Test")]
[assembly: InternalsVisibleTo("TPUM_2021.IntegrationTest")]

namespace TPUM_2021.ClientData
{
    internal class AppContext : IObservable<string>
    {
        private readonly Dictionary<Type, Type> typePairs;

        public AppContext(int p2p_port = 8081, bool connect = true)
        {
            this.p2p_port = p2p_port;

            observers = new List<IObserver<string>>();

            typePairs = new Dictionary<Type, Type>
            {
                { typeof(ICustomer), typeof(Customer) },
                { typeof(IProduct), typeof(Product) },
                { typeof(IInvoice), typeof(Invoice) }
            };

            if (connect)
                Task.Factory.StartNew(() => ConnectClient());
        }

        protected readonly int p2p_port;
        protected string Log { get; set; }
        protected Uri Peer => new Uri($@"ws://localhost:{p2p_port}/");
        protected List<IObserver<string>> observers;
        protected WebSocketConnection connection;

        public async Task ConnectClient()
        {
            connection = await WebSocketClient.Connect(Peer, message => Log = message);
            connection.onMessage = data =>
            {
                foreach (IObserver<string> observer in observers.ToArray())
                {
                    observer.OnNext(data);
                    observer.OnCompleted();
                }
            };
        }

        public async Task SendAsync(string message)
        {
            await connection.SendAsync(message);
        }

        public string Serialize(Type type, object obj)
        {
            using MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer serializer;
            Type dataType = typePairs[type];

            if (dataType == typeof(Customer))
            {
                obj = Map<Customer>(obj);
                serializer = new DataContractJsonSerializer(typeof(List<CustomerS>)); // TOut
            }
            else if (dataType == typeof(Product))
            {
                obj = Map<Product>(obj);
                serializer = new DataContractJsonSerializer(typeof(List<ProductS>)); // TOut
            }
            else if (dataType == typeof(Invoice))
            {
                obj = Map<Invoice>(obj);
                serializer = new DataContractJsonSerializer(typeof(List<InvoiceS>)); // TOut
            }
            else
            {
                throw new ArgumentException();
            }

            serializer.WriteObject(stream, obj);

            byte[] json = stream.ToArray();

            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        public TOut Deserialize<TOut>(string data) where TOut : class
        {
            using MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typePairs[typeof(TOut)]);

            return serializer.ReadObject(stream) as TOut;
        }

        public IEnumerable<TOut> DeserializeList<TOut>(string data) where TOut : IEntity
        {
            using MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
            Type dataType = typePairs[typeof(TOut)];
            DataContractJsonSerializer serializer;

            IEnumerable<TOut> result;

            if (dataType == typeof(Customer))
            {
                serializer = new DataContractJsonSerializer(typeof(List<CustomerS>)); // TOut
                result = new List<CustomerS>(serializer.ReadObject(stream) as IEnumerable<CustomerS>).Select(x => Map<CustomerS>(x) as ICustomer) as IEnumerable<TOut>;
            }
            else if (dataType == typeof(Product))
            {
                serializer = new DataContractJsonSerializer(typeof(List<ProductS>)); // TOut
                result = new List<ProductS>(serializer.ReadObject(stream) as IEnumerable<ProductS>).Select(x => Map<ProductS>(x) as IProduct) as IEnumerable<TOut>;
            }
            else if (dataType == typeof(Invoice))
            {
                serializer = new DataContractJsonSerializer(typeof(List<InvoiceS>)); // TOut
                result = new List<InvoiceS>(serializer.ReadObject(stream) as IEnumerable<InvoiceS>).Select(x => Map<InvoiceS>(x) as IInvoice) as IEnumerable<TOut>;
            }
            else
            {
                throw new ArgumentException();
            }

            return result;
        }

        public string GetTypeName(Type type)
        {
            if (type == typeof(ICustomer))
            {
                return "Customer";
            }
            else if (type == typeof(IProduct))
            {
                return "Product";
            }
            else if (type == typeof(IInvoice))
            {
                return "Invoice";
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private object Map<TIn>(object obj)
        {
            if (typeof(TIn) == typeof(Customer))
            {
                Customer tmp = obj as Customer;
                return new CustomerS
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    Funds = tmp.Funds
                };
            }

            if (typeof(TIn) == typeof(Product))
            {
                Product tmp = obj as Product;
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
                return new Customer
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    Funds = tmp.Funds
                };
            }

            if (typeof(TIn) == typeof(ProductS))
            {
                ProductS tmp = obj as ProductS;
                return new Product
                {
                    Id = tmp.Id,
                    Name = tmp.Name,
                    CustomerId = tmp.CustomerId,
                    Price = tmp.Price
                };
            }

            throw new ArgumentOutOfRangeException();
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>> _observers;
            private IObserver<string> _observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
