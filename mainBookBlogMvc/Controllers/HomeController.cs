using mainBookBlogMvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace mainBookBlogMvc.Controllers
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
            var books = _context.Books.ToList();
            return View(books);
        }
    }
}
