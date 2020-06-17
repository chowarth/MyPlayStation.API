using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Trophy
{
    public class TrophyCount
    {
        [JsonProperty( "bronze" )]
        public int Bronze { get; set; }

        [JsonProperty( "silver" )]
        public int Silver { get; set; }

        [JsonProperty( "gold" )]
        public int Gold { get; set; }

        [JsonProperty( "platinum" )]
        public int Platinum { get; set; }
    }
}
