﻿using MattermostAddinConnect.Utils;

namespace MattermostAddinConnect.Reply
{
    public class PermalinkDialogShell : IStringProvider
    {
        public string Get()
        {
            var dialog = new PermalinkDialog();
            dialog.ShowDialog();
            if (dialog.DialogResult == true)
            {
                return dialog.Permalink.Text;
            }
            throw new UserAbortException("cannot provide post id for: user abort");
        }
    }
}