using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class BackgroundImage
    {
        [JsonProperty( "sourceUrl" )]
        public string SourceUrl { get; set; }

        [JsonProperty( "resizeTemplate" )]
        public string ResizeTemplate { get; set; }

        [JsonProperty( "color" )]
        public string Colour { get; set; }
    }
}
