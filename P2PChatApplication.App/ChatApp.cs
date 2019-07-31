using System;
using System.Net.Sockets;
using System.Threading;

namespace P2PChatApplication.App
{
    public class ChatApp
    {
        public void Start()
        {
            UserConnectionDetails user = new UserConnectionDetails();
            user.GetMyConnectionDetails();
            Console.WriteLine();
            user.GetPeerConnectionDetails();

            NetworkListener listener = new NetworkListener(user);
            listener.BindSocket();
            listener.StartListening();

            NetworkClient client = new NetworkClient(user);
            Socket senderSocket = client.OnNewConnect();
            Socket receiverSocket = listener.AcceptConnection();

            Conversation conversation = new Conversation(senderSocket, receiverSocket, client, listener, user);

            Console.WriteLine("--------------Start Conversation----------------");

            Thread sendingThread = new Thread(new ThreadStart(() => conversation.SendMessage()));
            sendingThread.Start();
            Thread listeningThread = new Thread(new ThreadStart(() => conversation.ReceiveMessage()));
            listeningThread.Start();
        }
    }
}
