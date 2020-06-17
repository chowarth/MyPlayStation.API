using Newtonsoft.Json;
using MyPlayStation.API.Models.Profile;

namespace MyPlayStation.API.Responses
{
    public class GetProfileResponse
    {
        [JsonProperty( "profile" )]
        public Profile Profile { get; set; }
    }
}
