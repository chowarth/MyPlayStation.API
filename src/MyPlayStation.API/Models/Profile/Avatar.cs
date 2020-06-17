using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class Avatar
    {
        [JsonProperty( "size" )]
        public string Size { get; set; }

        [JsonProperty( "avatarUrl" )]
        public string AvatarUrl { get; set; }
    }
}
