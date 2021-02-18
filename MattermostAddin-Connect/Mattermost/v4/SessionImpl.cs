﻿using System;
using System.Collections.Generic;
using System.Linq;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v4.Interface;

namespace MattermostAddinConnect.Mattermost.v4
{
    public class SessionImpl : ISession
    {
        private readonly IRestService _restService;
        private readonly Uri _baseUri;
        private readonly string _token;
        private readonly string _teamId;
        private readonly IChatChannelFactory _chatChannelFactory;
        private readonly IChatPostFactory _chatPostFactory;

        public SessionImpl(IRestService restService, Uri baseUri, string token, string teamId,
            IChatChannelFactory chatChannelFactory, IChatPostFactory chatPostFactory)
        {
            _restService = restService;
            _baseUri = baseUri;
            _token = token;
            _teamId = teamId;
            _chatChannelFactory = chatChannelFactory;
            _chatPostFactory = chatPostFactory;
        }

        public IEnumerable<IChatChannel> GetChannels()
        {
            return _restService.GetChannels(_baseUri, _token, _teamId)
                .Select(c => _chatChannelFactory
                    .NewInstance(_restService, _baseUri, _token, _teamId, c));
        }

        public IChatChannel GetChannel(string channelId)
        {
            return _chatChannelFactory.NewInstance(_restService, _baseUri, _token, _teamId,
                new Channel {Id = channelId});
        }

        public IChatPost GetPost(string postId)
        {
            var post = _restService.GetPostById(_baseUri, _token, postId);
            return _chatPostFactory.NewInstance(_restService, _baseUri, _token, _teamId, post);
        }
    }
}