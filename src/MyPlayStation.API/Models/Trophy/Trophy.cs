using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Trophy
{
    public class Trophy
    {
        [JsonProperty( "trophyId" )]
        public int TrophyId { get; set; }

        [JsonProperty( "trophyHidden" )]
        public bool TrophyHidden { get; set; }

        [JsonProperty( "trophyType" )]
        public string TrophyType { get; set; }

        [JsonProperty( "trophyName" )]
        public string TrophyName { get; set; }

        [JsonProperty( "trophyDetail" )]
        public string TrophyDetail { get; set; }

        [JsonProperty( "trophyIconUrl" )]
        public string TrophyIconUrl { get; set; }

        [JsonProperty( "trophySmallIconUrl" )]
        public string TrophySmallIconUrl { get; set; }

        [JsonProperty( "trophyRare" )]
        public int TrophyRare { get; set; }

        [JsonProperty( "trophyEarnedRate" )]
        public string TrophyEarnedRate { get; set; }

        [JsonProperty( "fromUser" )]
        public TrophyUserSummary FromUser { get; set; }
    }
}
