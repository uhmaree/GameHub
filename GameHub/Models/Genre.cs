namespace GameHub.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public List<Game> Games { get; set; }
    }
}
