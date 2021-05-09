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

        public async Task StartServer()
        {
            await WebSocketServer.Server(p2p_port, connection => ServerSetup(connection));
        }

        private void ServerSetup(WebSocketConnection connection)
        {
            Sockets.Add(connection);
            connection.onMessage = async (data) =>
            {
                await connection.SendAsync(Resolve(data));
            };
            connection.onClose = () => Sockets.Remove(connection);
            connection.onError = () => Sockets.Remove(connection);
        }

        public abstract string Resolve(string data);
        public abstract void Dispose();
    }
}
