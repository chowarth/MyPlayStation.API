using Newtonsoft.Json;

namespace MyPlayStation.API.Requests
{
    public class GetAuthTokenRequest
    {
        [JsonProperty( "app_context" )]
        public string AppContext { get; set; }

        [JsonProperty( "duid" )]
        public string Duid { get; set; }

        [JsonProperty( "client_id" )]
        public string ClientId { get; set; }

        [JsonProperty( "client_secret" )]
        public string ClientSecret { get; set; }

        [JsonProperty( "grant_type" )]
        public string GrantType { get; set; }

        [JsonProperty( "scope" )]
        public string Scope { get; set; }

        [JsonProperty( "refresh_token" )]
        public string RefreshToken { get; set; }
    }
}
