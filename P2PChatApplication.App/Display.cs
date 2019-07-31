using System;

namespace P2PChatApplication.App
{
    public class Display : IDisplay
    {
        UserConnectionDetails _user;

        public Display(UserConnectionDetails user)
        {
            _user = user;
        }
        public string ShowMyMessage()
        {
            string message;
            Console.Write("");
            message = Console.ReadLine();
            return message;
        }

        public void ShowPeerMessage(string message)
        {
            Console.WriteLine($"\t\t\t{_user.ShowPeerUserName()} : {message}");
        }
    }
}
