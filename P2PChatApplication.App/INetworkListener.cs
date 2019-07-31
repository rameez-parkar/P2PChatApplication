using System.Net.Sockets;

namespace P2PChatApplication.App
{
    public interface INetworkListener
    {
        void BindSocket();
        void StartListening();
        Socket AcceptConnection();
        void StopConnection();
    }
}
