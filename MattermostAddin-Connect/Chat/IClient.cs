namespace MattermostAddinConnect.Chat
{
    public interface IClient
    {
        ISession LoginByUsername(string url, string teamId, string username, string password);
    }
}