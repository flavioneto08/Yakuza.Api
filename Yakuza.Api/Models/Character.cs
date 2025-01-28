namespace Yakuza.Api.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GameId { get; set; }
        public string? CharacterImageUrl { get; set; }

        //Navigation property
        public Game Game { get; set; }
    }
}
