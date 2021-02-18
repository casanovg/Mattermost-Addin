using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v3.Interface;

namespace MattermostAddinConnect.Error
{
    public interface IErrorDisplay
    {
        void Display(MattermostException mex);
        void Display(Exception exception);
    }
}