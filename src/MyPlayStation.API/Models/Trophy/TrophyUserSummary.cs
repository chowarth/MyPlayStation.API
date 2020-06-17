using System;
using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Trophy
{
    public class TrophyUserSummary
    {
        [JsonProperty( "onlineId" )]
        public string OnlineId { get; set; }

        [JsonProperty( "earned" )]
        public bool Earned { get; set; }

        [JsonProperty( "earnedDate" )]
        public DateTime EarnedDate { get; set; }
    }
}
