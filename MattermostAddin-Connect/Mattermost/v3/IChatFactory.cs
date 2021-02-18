using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v3.Interface;

namespace MattermostAddinConnect.Mattermost.v3
{
    public interface IChatFactory
    {
        ISession NewInstance(IRestService restService, Uri uri, string token, string userId, string teamId);
    }
}