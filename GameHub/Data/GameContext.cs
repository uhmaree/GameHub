using GameHub.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHub.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Sample data. Replace with your own favorites.
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Action-Adventure" },
                new Genre { GenreId = 2, Name = "Shooter" },
                new Genre { GenreId = 3, Name = "Strategy" },
                new Genre { GenreId = 4, Name = "Racing" },
                new Genre { GenreId = 5, Name = "Simulation" }
            );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameId = 1, Title = "The Legend of Zelda: Breath of the Wild", Platform = "Nintendo Switch", ReleaseYear = 2017, HoursPlayed = 120, Rating = 10, GenreId = 1, Notes = "Open world that rewards curiosity." },
                new Game { GameId = 2, Title = "Elden Ring", Platform = "PC", ReleaseYear = 2022, HoursPlayed = 90, Rating = 9, GenreId = 1, Notes = "Tough bosses, huge world." },
                new Game { GameId = 3, Title = "Halo Infinite", Platform = "Xbox", ReleaseYear = 2021, HoursPlayed = 60, Rating = 8, GenreId = 2, Notes = "Great multiplayer with friends." },
                new Game { GameId = 4, Title = "Overwatch 2", Platform = "PC", ReleaseYear = 2022, HoursPlayed = 75, Rating = 7, GenreId = 2, Notes = "Fast team shooter." },
                new Game { GameId = 5, Title = "Civilization VI", Platform = "PC", ReleaseYear = 2016, HoursPlayed = 200, Rating = 9, GenreId = 3, Notes = "One more turn." },
                new Game { GameId = 6, Title = "XCOM 2", Platform = "PC", ReleaseYear = 2016, HoursPlayed = 80, Rating = 9, GenreId = 3, Notes = "Tense turn-based tactics." },
                new Game { GameId = 7, Title = "Forza Horizon 5", Platform = "Xbox", ReleaseYear = 2021, HoursPlayed = 50, Rating = 9, GenreId = 4, Notes = "Beautiful open-world racing." },
                new Game { GameId = 8, Title = "Mario Kart 8 Deluxe", Platform = "Nintendo Switch", ReleaseYear = 2017, HoursPlayed = 110, Rating = 9, GenreId = 4, Notes = "Best party game." },
                new Game { GameId = 9, Title = "The Sims 4", Platform = "PC", ReleaseYear = 2014, HoursPlayed = 300, Rating = 8, GenreId = 5, Notes = "Build houses and tell stories." },
                new Game { GameId = 10, Title = "Stardew Valley", Platform = "PC", ReleaseYear = 2016, HoursPlayed = 140, Rating = 10, GenreId = 5, Notes = "Relaxing farming and community." }
            );
        }
    }
}
