using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v4.Interface;

namespace MattermostAddinConnect.Mattermost.v4
{
    public interface IChatChannelFactory
    {
        IChatChannel NewInstance(IRestService restService, Uri baseUri, string token, string teamId, Channel channel);
    }
}