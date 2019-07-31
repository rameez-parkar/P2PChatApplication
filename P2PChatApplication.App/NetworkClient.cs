using System;
using System.Net.Sockets;

namespace P2PChatApplication.App
{
    public class NetworkClient
    {
        Network _network = new Network();
        UserConnectionDetails _user;
        public NetworkClient(UserConnectionDetails user)
        {
            _user = user;
            _network.CreateSocket(_user.ShowPeerIpAddress(), _user.ShowPeerPortNumber());
        }
        public Socket Connect()
        {
            _network.ShowSocket().Connect(_network.ShowEndPoint());
            return _network.ShowSocket();
        }
        public Socket OnNewConnect()
        {
            Socket senderSocket = null;
            var flag = true;
            while (flag)
            {
                try
                {
                    senderSocket = Connect();
                    flag = false;
                    Console.WriteLine("Connected!");
                }
                catch
                {
                    //Console.WriteLine("Waiting for connection");
                }
            }
            return senderSocket;
        }

        public void StopConnection(Socket senderSocket)
        {
            try
            {
                senderSocket.Shutdown(SocketShutdown.Both);
                senderSocket.Close();
                Console.WriteLine("-----------------Conversation Ended-------------------");
            }
            catch (Exception e)
            {
            }

        }
    }
}
