using Newtonsoft.Json;

namespace MyPlayStation.API.Models.Profile
{
    public class Availability
    {
        [JsonProperty( "availabilityStatus" )]
        public string AvailabilityStatus { get; set; }
    }
}
