using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v4.Interface;

namespace MattermostAddinConnect.Mattermost.v4
{
    public interface IChatFactory
    {
        ISession NewInstance(IRestService restService, Uri baseUri, string token, string teamId);
    }
}
