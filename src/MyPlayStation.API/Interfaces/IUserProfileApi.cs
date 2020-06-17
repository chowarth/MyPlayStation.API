using System.Threading.Tasks;
using MyPlayStation.API.Requests;
using MyPlayStation.API.Responses;
using Refit;

namespace MyPlayStation.API.Interfaces
{
    [Headers( "Authorization: Bearer" )]
    public interface IUserProfileApi
    {
        [Get( "/userProfile/v1/users/{request.OnlineId}/profile2?fields=onlineId%2CaboutMe%2CconsoleAvailability%2ClanguagesUsed%2CavatarUrls%2CpersonalDetail%2CpersonalDetail(%40default%2CprofilePictureUrls)%2CprimaryOnlineStatus%2CtrophySummary(level%2Cprogress%2CearnedTrophies)%2Cplus%2CisOfficiallyVerified%2CfriendRelation%2CpersonalDetailSharing%2Cpresences(%40default%2Cplatform)%2CnpId%2Cblocking%2Cfollowing%2CcurrentOnlineId%2CdisplayableOldOnlineId%2CmutualFriendsCount%2CfollowerCount&profilePictureSizes=s%2Cm%2Cl&avatarSizes=s%2Cm%2Cl&languagesUsedLanguageSet=set4" )]
        Task<GetProfileResponse> GetProfileAsync( GetProfileRequest request );
    }
}
