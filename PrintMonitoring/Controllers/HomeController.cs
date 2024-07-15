using Microsoft.AspNetCore.Mvc;
using YourNamespace.Data;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var printEvents = _context.PrintEvents.ToList();
            return View(printEvents);
        }
    }
}
