using Microsoft.Office.Interop.Outlook;

namespace MattermostAddinConnect.Mail
{
    public interface IMailExplorer
    {
        MailItem QuerySelectedMailItem();
    }
}