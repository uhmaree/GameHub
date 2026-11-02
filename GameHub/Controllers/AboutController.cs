using Microsoft.AspNetCore.Mvc;

namespace GameHub.Controllers
{
    public class AboutController : Controller
    {
        // About the team / about me page
        public IActionResult Index() => View();
    }
}
