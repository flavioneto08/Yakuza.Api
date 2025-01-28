namespace Yakuza.Api.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LaunchDate { get; set; }
        public string? GameBannerImageUrl { get; set; }
    }
}
