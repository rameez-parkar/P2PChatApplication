using System.Net.Sockets;

namespace P2PChatApplication.App
{
    public interface INetworkClient
    {
        Socket Connect();
        Socket OnNewConnect();
        void StopConnection();
    }
}
