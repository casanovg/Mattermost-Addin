using Microsoft.Office.Interop.Outlook;
using MattermostAddinConnect.Mail;

namespace MattermostAddin
{
    public class OutlookExplorerService : IExplorerService
    {
        public Explorer GetActiveExplorer()
        {
            return Globals.ThisAddIn.Application.ActiveExplorer();
        }
    }
}