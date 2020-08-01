using MyPlayStation.API.Models.Profile;
using Newtonsoft.Json;

namespace MyPlayStation.API.Responses
{
    public class GetProfileBackgroundImageResponse
    {
        [JsonProperty( "backgroundImage" )]
        public BackgroundImage Image { get; set; }

        // TODO: [JsonProperty( "availability" )]
    }
}
