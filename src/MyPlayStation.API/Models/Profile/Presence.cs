using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class Presence
    {
        [JsonProperty( "platform" )]
        public string Platform { get; set; }
    }
}
