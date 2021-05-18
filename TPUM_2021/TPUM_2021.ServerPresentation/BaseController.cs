using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TPUM_2021.CommonWebSocketApi;

namespace TPUM_2021.ServerPresentation
{
    public abstract class BaseController : IDisposable
    {
        public BaseController(int p2p_port)
        {
            this.p2p_port = p2p_port;
        }

        protected readonly int p2p_port;
        protected List<WebSocketConnection> Sockets { get; set; } = new List<WebSocketConnection>();
        protected Action<string> Log { get; } = data => Console.WriteLine(data);

        public async Task StartServer()
        {
            await WebSocketServer.Server(p2p_port, async connection => await ServerSetup(connection));
        }

        private async Task ServerSetup(WebSocketConnection connection)
        {
            Sockets.Add(connection);
            connection.onMessage = async (data) =>
            {
                Log($"[Message]: {data}");
                await connection.SendAsync(Resolve(data));
            };
            connection.onClose = () =>
            {
                Log($"[Closing connection]: {connection}");
                Sockets.Remove(connection);
            };
            connection.onError = () =>
            {
                Log($"[Error! Closing connection]: {connection}");
                Sockets.Remove(connection);
            };

            Log("[Sending message] Connected");
            await connection.SendAsync("Connected");
        }

        public abstract string Resolve(string data);
        public abstract void Dispose();
    }
}
