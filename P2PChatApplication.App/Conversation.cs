using System;
using System.Net.Sockets;
using System.Text;

namespace P2PChatApplication.App
{
    public class Conversation : IConversation
    {
        private Display _display;
        private Socket _senderSocket;
        private NetworkClient _client;
        private NetworkListener _listener;
        private Socket _receiverSocket;
        public Conversation(Socket senderSocket, Socket receiverSocket, NetworkClient client, NetworkListener listener, UserConnectionDetails user)
        {
            _senderSocket = senderSocket;
            _receiverSocket = receiverSocket;
            _client = client;
            _listener = listener;
            _display = new Display(user);
        }

        public void SendMessage()
        {
            try
            {
                while (true)
                {
                    string message = _display.ShowMyMessage();
                    byte[] sentMessage = Encoding.ASCII.GetBytes(message);
                    _senderSocket.Send(sentMessage);
                    if (message.ToLowerInvariant().Equals("bye"))
                    {
                        _client.StopConnection(_senderSocket);
                        break;
                    }
                }
            }
            catch(Exception e)
            {

            }
        }

        public void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    byte[] receiveMessage = new byte[1024];
                    int receiveMessageCount = _receiverSocket.Receive(receiveMessage);
                    string message = Encoding.ASCII.GetString(receiveMessage, 0, receiveMessageCount);
                    _display.ShowPeerMessage(message);
                    if (message.ToLowerInvariant().Equals("bye"))
                    {
                        _listener.StopConnection(_receiverSocket);
                        break;
                    }
                }
            }
            catch(Exception e)
            {
            }
        }
    }
}
