using System.Collections.Generic;

namespace MattermostAddinConnect.Chat
{
    public interface ISession
    {
        IEnumerable<IChatChannel> GetChannels();
        IChatChannel GetChannel(string channelId);
        IChatPost GetPost(string postId);
    }
}