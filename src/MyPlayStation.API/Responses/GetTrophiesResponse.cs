using Newtonsoft.Json;
using MyPlayStation.API.Models.Trophy;

namespace MyPlayStation.API.Responses
{
    public class GetTrophiesResponse
    {
        [JsonProperty( "trophies" )]
        public Trophy[] Trophies { get; set; }
    }
}
