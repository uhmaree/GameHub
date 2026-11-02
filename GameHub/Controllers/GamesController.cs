using GameHub.Data;
using GameHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHub.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameContext _context;

        // DbContext is injected by the framework (registered in Program.cs)
        public GamesController(GameContext context) => _context = context;

        public IActionResult Index(int? genreId)
        {
            var query = _context.Games.Include(g => g.Genre).AsQueryable();
            if (genreId.HasValue)
            {
                query = query.Where(g => g.GenreId == genreId.Value);
            }

            var model = new GamesIndexViewModel
            {
                Games = query.OrderBy(g => g.Title).ToList(),
                Genres = _context.Genres.OrderBy(g => g.Name).ToList(),
                SelectedGenreId = genreId
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var game = _context.Games.Include(g => g.Genre).FirstOrDefault(g => g.GameId == id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }
    }
}
