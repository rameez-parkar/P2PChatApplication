namespace P2PChatApplication.App
{
    public interface IDisplay
    {
        string ShowMyMessage();
        void ShowPeerMessage(string message);
    }
}
