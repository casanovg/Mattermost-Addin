using Microsoft.Office.Interop.Outlook;

namespace MattermostAddinConnect.Mail
{
    public interface IExplorerService
    {
        Explorer GetActiveExplorer();
    }
}