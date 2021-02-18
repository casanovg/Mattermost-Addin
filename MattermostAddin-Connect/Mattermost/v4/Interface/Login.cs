using Newtonsoft.Json;

namespace MattermostAddinConnect.Mattermost.v4.Interface
{
    public class Login
    {
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
