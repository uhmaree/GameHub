using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Platform { get; set; }
        public int ReleaseYear { get; set; }
        public int HoursPlayed { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }

        public string Notes { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
