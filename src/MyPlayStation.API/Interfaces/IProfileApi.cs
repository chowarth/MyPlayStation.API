using System.Threading.Tasks;
using MyPlayStation.API.Requests;
using MyPlayStation.API.Responses;
using Refit;

namespace MyPlayStation.API.Interfaces
{
    [Headers( "Authorization: Bearer" )]
    public interface IProfileApi
    {
        [Get( "/v1/users/{request.OnlineId}/profile?fields=backgroundImage" )]
        Task<GetProfileBackgroundImageResponse> GetProfileBackgroundImageAsync( GetProfileBackgroundImageRequest request );
    }
}
