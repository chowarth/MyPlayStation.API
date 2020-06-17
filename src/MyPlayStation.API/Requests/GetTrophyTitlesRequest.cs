
namespace MyPlayStation.API.Requests
{
    public class GetTrophyTitlesRequest
    {
        public int Limit { get; set; } = 125;
        public int Offset { get; set; } = 0;
    }
}
