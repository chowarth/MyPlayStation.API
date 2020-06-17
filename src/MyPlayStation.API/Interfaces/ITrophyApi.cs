using System.Threading.Tasks;
using MyPlayStation.API.Requests;
using MyPlayStation.API.Responses;
using Refit;

namespace MyPlayStation.API.Interfaces
{
    [Headers( "Authorization: Bearer" )]
    public interface ITrophyApi
    {
        [Get( "/trophy/v1/trophyTitles?limit={request.Limit}&offset={request.Offset}&fields=%40default%2CtrophyTitleSmallIconUrl&platform=PS3%2CPS4%2CPSVITA&npLanguage=en-GB" )]
        Task<GetTrophyTitlesResponse> GetTrophyTitlesAsync( GetTrophyTitlesRequest request );

        [Get( "/trophy/v1/trophyTitles/{request.NpCommunicationId}/trophyGroups?fields=%40default%2CtrophyGroupSmallIconUrl&npLanguage=en-GB" )]
        Task<GetTrophyGroupsResponse> GetTrophyGroupsAsync( GetTrophyGroupsRequest request );

        [Get( "/trophy/v1/trophyTitles/{request.NpCommunicationId}/trophyGroups/{request.TrophyGroupId}/trophies?fields=%40default%2CtrophyRare%2CtrophyEarnedRate%2CtrophySmallIconUrl&visibleType=1&npLanguage=en-GB" )]
        Task<GetTrophiesResponse> GetTrophiesAsync( GetTrophiesRequest request );
    }
}
