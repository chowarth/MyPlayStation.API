using Newtonsoft.Json;
using MyPlayStation.API.Models.Trophy;

namespace MyPlayStation.API.Models.Profile
{
    public class ProfileTrophySummary
    {
        [JsonProperty( "level" )]
        public int Level { get; set; }

        [JsonProperty( "progress" )]
        public int Progress { get; set; }

        [JsonProperty( "earnedTrophies" )]
        public TrophyCount EarnedTrophies { get; set; }
    }
}
