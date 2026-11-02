namespace GameHub.Models
{
    public class GamesIndexViewModel
    {
        public List<Game> Games { get; set; }
        public List<Genre> Genres { get; set; }
        public int? SelectedGenreId { get; set; }
    }
}
