using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v4.Interface;

namespace MattermostAddinConnect.Mattermost.v4
{
    public class ChatFactory : IChatFactory, IChatChannelFactory, IChatPostFactory
    {
        public ISession NewInstance(IRestService restService, Uri baseUri, string token, string teamId)
        {
            return new SessionImpl(restService, baseUri, token, teamId, this, this);
        }

        public IChatChannel NewInstance(IRestService restService, Uri baseUri, string token, string teamId,
            Channel channel)
        {
            return new ChatChannel(restService, baseUri, token, teamId, channel);
        }

        public IChatPost NewInstance(IRestService restService, Uri baseUri, string token, string teamId, Post post)
        {
            return new ChatPost(restService, baseUri, token, teamId, post);
        }
    }
}