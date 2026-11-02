using Microsoft.AspNetCore.Mvc;

namespace GameHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Hobby() => View();

        public IActionResult Contact() => View();
    }
}
