using System;

namespace P2PChatApplication.App
{
    public class UserConnectionDetails
    {
        private string _myUserName;
        private int _myPort;
        private string _myIpAddress;
        private string _peerUserName;
        private int _peerPort;
        private string _peerIpAddress;

        public void GetMyConnectionDetails()
        {
            Console.Write("Enter your username : ");
            _myUserName = Console.ReadLine();
            Console.Write("Enter your IP Address : ");
            _myIpAddress = Console.ReadLine();
            Console.Write("Enter your port : ");
            _myPort = int.Parse(Console.ReadLine());
        }

        public void GetPeerConnectionDetails()
        {
            Console.Write("Enter peer username : ");
            _peerUserName = Console.ReadLine();
            Console.Write("Enter peer IP Address : ");
            _peerIpAddress = Console.ReadLine();
            Console.Write("Enter peer port : ");
            _peerPort = int.Parse(Console.ReadLine());
        }

        public string ShowMyUserName()
        {
            return _myUserName;
        }

        public string ShowMyIpAddress()
        {
            return _myIpAddress;
        }

        public int ShowMyPortNumber()
        {
            return _myPort;
        }
        public string ShowPeerUserName()
        {
            return _peerUserName;
        }
        public string ShowPeerIpAddress()
        {
            return _peerIpAddress;
        }

        public int ShowPeerPortNumber()
        {
            return _peerPort;
        }
    }
}
