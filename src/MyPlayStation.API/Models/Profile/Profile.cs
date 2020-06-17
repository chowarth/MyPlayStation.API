using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class Profile
    {
        [JsonProperty( "onlineId" )]
        public string OnlineId { get; set; }

        [JsonProperty( "npId" )]
        public string NpId { get; set; }

        [JsonProperty( "avatarUrls" )]
        public Avatar[] AvatarUrls { get; set; }

        [JsonProperty("plus")]
        public bool Plus { get; set; }

        [JsonProperty( "aboutMe" )]
        public string AboutMe { get; set; }

        [JsonProperty( "languagesUsed" )]
        public string[] LanguagesUsed { get; set; }

        [JsonProperty( "trophySummary" )]
        public ProfileTrophySummary TrophySummary { get; set; }

        [JsonProperty( "isOfficiallyVerified" )]
        public bool IsOfficiallyVerified { get; set; }

        [JsonProperty( "personalDetail" )]
        public PersonalDetails PersonalDetail { get; set; }

        [JsonProperty( "personalDetailSharing" )]
        public string PersonalDetailSharing { get; set; }

        [JsonProperty( "primaryOnlineStatus" )]
        public string PrimaryOnlineStatus { get; set; }

        [JsonProperty( "presences" )]
        public Presence[] Presences { get; set; }

        [JsonProperty( "friendRelation" )]
        public string FriendRelation { get; set; }

        [JsonProperty( "blocking" )]
        public bool Blocking { get; set; }

        [JsonProperty( "mutualFriendsCount" )]
        public int MutualFriendsCount { get; set; }

        [JsonProperty( "following" )]
        public bool Following { get; set; }

        [JsonProperty( "followerCount" )]
        public int FollowerCount { get; set; }

        [JsonProperty( "consoleAvailability" )]
        public Availability ConsoleAvailability { get; set; }
    }
}
