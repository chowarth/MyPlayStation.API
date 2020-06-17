using Newtonsoft.Json;
using MyPlayStation.API.Models.Profile;

namespace MyPlayStation.API.Models.Trophy
{
    public class TrophyTitle
    {
        [JsonProperty( "npCommunicationId" )]
        public string NpCommunicationId { get; set; }

        [JsonProperty( "trophyTitleName" )]
        public string TrophyTitleName { get; set; }

        [JsonProperty( "trophyTitleDetail" )]
        public string TrophyTitleDetail { get; set; }

        [JsonProperty( "trophyTitleIconUrl" )]
        public string TrophyTitleIconUrl { get; set; }

        [JsonProperty( "trophyTitleSmallIconUrl" )]
        public string TrophyTitleSmallIconUrl { get; set; }

        [JsonProperty( "trophyTitlePlatfrom" )]
        public string TrophyTitlePlatform { get; set; }

        [JsonProperty( "hasTrophyGroups" )]
        public bool HasTrophyGroups { get; set; }

        [JsonProperty( "definedTrophies" )]
        public TrophyCount DefinedTrophies { get; set; }

        [JsonProperty( "fromUser" )]
        public ProfileSummary FromUser { get; set; }
    }
}
