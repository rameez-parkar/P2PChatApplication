using System.Net;
using System.Net.Sockets;

namespace P2PChatApplication.App
{
    public class Network
    {
        private Socket _socket;
        private IPEndPoint _endPoint;
        public void CreateSocket(string ip, int portNumber)
        {
            IPAddress ipAddress = IPAddress.Parse(ip);
            _endPoint = new IPEndPoint(ipAddress, portNumber);
            _socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public Socket ShowSocket()
        {
            return _socket;
        }

        public IPEndPoint ShowEndPoint()
        {
            return _endPoint;
        }
    }
}
