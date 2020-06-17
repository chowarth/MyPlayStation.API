using System;
using Newtonsoft.Json;
using MyPlayStation.API.Models.Trophy;

namespace MyPlayStation.API.Models.Profile
{
    public class ProfileSummary
    {
        [JsonProperty( "onlineId" )]
        public string OnlineId { get; set; }

        [JsonProperty( "progress" )]
        public int Progress { get; set; }

        [JsonProperty( "earnedTrophies" )]
        public TrophyCount EarnedTrophies { get; set; }

        [JsonProperty( "hiddenFlag" )]
        public bool HiddenFlag { get; set; }

        [JsonProperty( "lastUpdateDate" )]
        public DateTime LastUpdateDate { get; set; }
    }
}
