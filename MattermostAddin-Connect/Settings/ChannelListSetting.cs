using System.Collections.Generic;
using Newtonsoft.Json;

namespace MattermostAddinConnect.Settings
{
    public class ChannelListSetting
    {
        [JsonProperty("channels")]
        public List<ChannelSetting> Channels { get; set; }
    }
}