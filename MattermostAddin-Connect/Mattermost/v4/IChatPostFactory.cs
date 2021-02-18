using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v4.Interface;

namespace MattermostAddinConnect.Mattermost.v4
{
    public interface IChatPostFactory
    {
        IChatPost NewInstance(IRestService restService, Uri baseUri, string token, string teamId, Post post);
    }
}