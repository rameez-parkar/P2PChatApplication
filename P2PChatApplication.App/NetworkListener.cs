using System;
using System.Net.Sockets;

namespace P2PChatApplication.App
{
    public class NetworkListener
    {
        Network _network = new Network();
        UserConnectionDetails _user;
        public NetworkListener(UserConnectionDetails user)
        {
            _user = user;
            _network.CreateSocket(_user.ShowMyIpAddress(), _user.ShowMyPortNumber());
        }

        public void BindSocket()
        {
            _network.ShowSocket().Bind(_network.ShowEndPoint());
        }

        public void StartListening()
        {
            _network.ShowSocket().Listen(10);
        }
        
        public Socket AcceptConnection()
        {
            return _network.ShowSocket().Accept();
        }

        public void StopConnection(Socket receiverSocket)
        {
            try
            {
                receiverSocket.Shutdown(SocketShutdown.Both);
                receiverSocket.Close();
                Console.WriteLine("-----------------Conversation Ended-------------------");
            }
            catch (Exception e)
            {
            }
        }
    }
}
