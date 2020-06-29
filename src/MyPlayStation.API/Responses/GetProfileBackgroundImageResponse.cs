using Newtonsoft.Json;

namespace MyPlayStation.API.Responses
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

    public class GetProfileBackgroundImageResponse
    {
        [JsonProperty( "backgroundImage" )]
        public BackgroundImage Image { get; set; }

        // TODO: [JsonProperty( "availability" )]
    }
}
