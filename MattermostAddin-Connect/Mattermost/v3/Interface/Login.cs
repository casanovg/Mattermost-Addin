using Newtonsoft.Json;

namespace MattermostAddinConnect.Mattermost.v3.Interface
{
    public struct Login
    {
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}