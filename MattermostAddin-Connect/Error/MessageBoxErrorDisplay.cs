﻿using System;
using System.Windows;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v3.Interface;

namespace MattermostAddinConnect.Error
{
    public class MessageBoxErrorDisplay : IErrorDisplay
    {
        public void Display(MattermostException mex)
        {
            MessageBox.Show("Mattermost says: " + mex.Message + " (" + mex.Details + ")", "Mattermost Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public void Display(Exception exception)
        {
            MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}