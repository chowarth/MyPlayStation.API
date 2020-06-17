using Newtonsoft.Json;
using MyPlayStation.API.Models.Trophy;

namespace MyPlayStation.API.Responses
{
    public class GetTrophyTitlesResponse
    {
        [JsonProperty( "totalResults" )]
        public int TotalResults { get; set; }

        [JsonProperty( "offset" )]
        public int Offset { get; set; }

        [JsonProperty( "limit" )]
        public int Limit { get; set; }

        [JsonProperty( "trophyTitles" )]
        public TrophyTitle[] TrophyTitles { get; set; }
    }
}
