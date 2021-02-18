﻿using Newtonsoft.Json;

namespace MattermostAddinConnect.Mattermost.v4.Interface
{
    public class Post
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("root_it")]
        public string RootId { get; set; }

        protected bool Equals(Post other)
        {
            return string.Equals(Id, other.Id) && string.Equals(ChannelId, other.ChannelId) &&
                   string.Equals(Message, other.Message) &&
                   string.Equals(RootId, other.RootId);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Post)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ChannelId != null ? ChannelId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Message != null ? Message.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RootId != null ? RootId.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
