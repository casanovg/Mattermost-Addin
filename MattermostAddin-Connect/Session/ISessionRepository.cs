using System.Threading.Tasks;
using MattermostAddinConnect.Chat;

namespace MattermostAddinConnect.Session
{
    public interface ISessionRepository
    {
        Task<ISession> RestoreSession();
    }
}