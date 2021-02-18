using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MattermostAddinConnect.Settings
{
    [JsonConverter(typeof (StringEnumConverter))]
    public enum ChannelTypeSetting
    {
        [EnumMember(Value = "O")] Public,
        [EnumMember(Value = "P")] Private,
        [EnumMember(Value = "D")] Direct
    }
}