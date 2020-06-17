using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class ProfilePicture
    {
        [JsonProperty( "size" )]
        public string Size { get; set; }

        [JsonProperty( "profilePictureUrl" )]
        public string ProfilePictureUrl { get; set; }
    }
}
