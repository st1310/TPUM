using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonData;
using TPUM_2021.CommonData.Model;
using TPUM_2021.CommonWebSocketApi;

[assembly: InternalsVisibleTo("TPUM_2021.Test")]

namespace TPUM_2021.ClientData
{
    internal class AppContext : IObservable<string>
    {
        private readonly Dictionary<Type, Type> typePairs;

        public AppContext(int p2p_port = 8081)
        {
            this.p2p_port = p2p_port;

            observers = new List<IObserver<string>>();

            typePairs = new Dictionary<Type, Type>
            {
                { typeof(ICustomer), typeof(Customer) },
                { typeof(IProduct), typeof(Product) },
                { typeof(IInvoice), typeof(Invoice) }
            };

            //ConnectClient().Wait();
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
                foreach (IObserver<string> observer in observers)
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

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typePairs[type]);
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

            if (dataType == typeof(Customer))
            {
                serializer = new DataContractJsonSerializer(typeof(List<Customer>));
            }
            else if (dataType == typeof(Product))
            {
                serializer = new DataContractJsonSerializer(typeof(List<Product>));
            }
            else if (dataType == typeof(Invoice))
            {
                serializer = new DataContractJsonSerializer(typeof(List<Invoice>));
            }
            else
            {
                throw new ArgumentException();
            }

            return serializer.ReadObject(stream) as IEnumerable<TOut>;
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
