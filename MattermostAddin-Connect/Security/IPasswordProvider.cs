namespace MattermostAddinConnect.Security
{
    public interface IPasswordProvider
    {
        string GetPassword(string username);
    }
}