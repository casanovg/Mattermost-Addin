using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v3.Interface;

namespace MattermostAddinConnect.Mattermost.v3
{
    public interface IChatChannelFactory
    {
        IChatChannel NewInstance(IRestService restService, Uri baseUri, string token, string userId, string teamId,
            Channel channel);
    }
}