﻿using Microsoft.Office.Interop.Outlook;

namespace MattermostAddinConnect.Mail
{
    public class OutlookMailExplorer : IMailExplorer
    {
        private readonly IExplorerService _explorerService;

        public OutlookMailExplorer(IExplorerService explorerService)
        {
            _explorerService = explorerService;
        }

        public MailItem QuerySelectedMailItem()
        {
            var explorer = _explorerService.GetActiveExplorer();
            if (explorer == null)
            {
                throw new MailException("Could not find mail explorer object");
            }
            if (explorer.Selection == null)
            {
                throw new MailException("No selection information available");
            }
            if (explorer.Selection.Count == 0)
            {
                throw new MailException("No mails selected");
            }
            var item = explorer.Selection[1] as MailItem;
            if (item == null)
            {
                throw new MailException("Selected item is not a mail item");
            }
            return item;
        }
    }
}