using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v3.Interface;

namespace MattermostAddinConnect.Mattermost.v3
{
    public interface IChatPostFactory
    {
        IChatPost NewInstance(IRestService restService, Uri baseUri, string token, string teamId, Post post);
    }
}