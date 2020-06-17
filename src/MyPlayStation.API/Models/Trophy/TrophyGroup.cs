using Newtonsoft.Json;
using MyPlayStation.API.Models.Profile;

namespace MyPlayStation.API.Models.Trophy
{
    public class TrophyGroup
    {
        [JsonProperty( "trophyGroupId" )]
        public string TrophyGroupId { get; set; }

        [JsonProperty( "trophyGroupName" )]
        public string TrophyGroupName { get; set; }

        [JsonProperty( "trophyGroupDetail" )]
        public string TrophyGroupDetail { get; set; }

        [JsonProperty( "trophyGroupIconUrl" )]
        public string TrophyGroupIconUrl { get; set; }

        [JsonProperty( "trophyGroupSmallIconUrl" )]
        public string TrophyGroupSmallIconUrl { get; set; }

        [JsonProperty( "definedTrophies" )]
        public TrophyCount DefinedTrophies { get; set; }

        [JsonProperty( "fromUser" )]
        public ProfileSummary FromUser { get; set; }
    }
}
