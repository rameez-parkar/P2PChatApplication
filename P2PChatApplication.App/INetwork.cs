using System.Net;
using System.Net.Sockets;

namespace P2PChatApplication.App
{
    public interface INetwork
    {
        void CreateSocket(string ip, int portNumber);
        Socket ShowSocket();
        IPEndPoint ShowEndPoint();
    }
}
