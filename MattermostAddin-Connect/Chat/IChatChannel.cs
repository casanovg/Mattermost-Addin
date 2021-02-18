using MattermostAddinConnect.Settings;

namespace MattermostAddinConnect.Chat
{
    public interface IChatChannel
    {
        void CreatePost(string message);
        ChannelSetting ToSetting();
    }
}