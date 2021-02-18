﻿using System;
using MattermostAddinConnect.Chat;
using MattermostAddinConnect.Mattermost.v4.Interface;
using MattermostAddinConnect.Settings;

namespace MattermostAddinConnect.Mattermost.v4
{
    public class ChatChannel : IChatChannel

    {
        private Uri _baseUri;
        private Channel _channel;
        private IRestService _restService;
        private string _teamId;
        private string _token;

        public ChatChannel(IRestService restService, Uri baseUri, string token, string teamId, Channel channel)
        {
            _restService = restService;
            _baseUri = baseUri;
            _token = token;
            _teamId = teamId;
            _channel = channel;
        }

        public void CreatePost(string message)
        {
            var post = new Post
            {
                ChannelId = _channel.Id,
                Message = message
            };
            _restService.CreatePost(_baseUri, _token, post);
        }

        public ChannelSetting ToSetting()
        {
            return new ChannelSetting
            {
                ChannelId = _channel.Id,
                ChannelName = _channel.Name,
                Type = ConvertType(_channel.Type)
            };
        }

        private ChannelTypeSetting ConvertType(ChannelType type)
        {
            switch (type)
            {
                case ChannelType.Direct:
                    return ChannelTypeSetting.Direct;
                case ChannelType.Public:
                    return ChannelTypeSetting.Public;
                case ChannelType.Private:
                    return ChannelTypeSetting.Public;
                // GC: Option added to support the "G" type channels of newer Mattermost versions
                case ChannelType.Peers:
                    return ChannelTypeSetting.Direct;
                default:
                    return ChannelTypeSetting.Public;
            }
        }
    }
}
