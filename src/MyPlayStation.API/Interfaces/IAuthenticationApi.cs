using System.Threading.Tasks;
using MyPlayStation.API.Requests;
using MyPlayStation.API.Responses;
using Refit;

namespace MyPlayStation.API.Interfaces
{
    public interface IAuthenticationApi
    {
        [Post( "/oauth/token" )]
        Task<GetAuthTokenResponse> AuthenticateWithNpssoAsync( [Header("Cookie")] string npsso, [Body(BodySerializationMethod.UrlEncoded)] GetAuthTokenRequest request );

        [Post( "/oauth/token" )]
        Task<GetAuthTokenResponse> RefreshTokenAsync( [Body( BodySerializationMethod.UrlEncoded )] GetAuthTokenRequest request );
    }
}
