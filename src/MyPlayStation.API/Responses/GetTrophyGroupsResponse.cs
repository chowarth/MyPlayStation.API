using Newtonsoft.Json;
using MyPlayStation.API.Models.Trophy;

namespace MyPlayStation.API.Responses
{
    public class GetTrophyGroupsResponse
    {
        [JsonProperty( "trophyTitleName" )]
        public string TrophyTitleName { get; set; }

        [JsonProperty( "trophyTitleDetail" )]
        public string TrophyTitleDetail { get; set; }

        [JsonProperty( "trophyTitleIconUrl" )]
        public string TrophyTitleIconUrl { get; set; }

        [JsonProperty( "trophyTitlePlatfrom" )]
        public string TrophyTitlePlatform { get; set; }

        [JsonProperty( "definedTrophies" )]
        public TrophyCount DefinedTrophies { get; set; }

        [JsonProperty( "trophyGroups" )]
        public TrophyGroup[] TrophyGroups { get; set; }
    }
}
