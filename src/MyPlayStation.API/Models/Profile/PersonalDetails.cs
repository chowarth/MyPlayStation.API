using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class PersonalDetails
    {
        [JsonProperty( "firstName" )]
        public string FirstName { get; set; }

        [JsonProperty( "lastName" )]
        public string LastName { get; set; }

        [JsonProperty( "profilePictureUrls" )]
        public ProfilePicture[] ProfilePictureUrls { get; set; }
    }
}
