using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Settings;

namespace MattermostAddinConnect.Session
{
    public interface IClientFactory
    {
        IClient GetClient(MattermostVersion version);
    }
}