using System.Collections.Generic;
using MyPlayStation.API.Models.Profile;
using Newtonsoft.Json;

namespace MyPlayStation.API.Responses
{
    public class GetFriendsResponse
    {
        [JsonProperty( "profiles" )]
        public IList<Profile> Profiles { get; set; }
    }
}
