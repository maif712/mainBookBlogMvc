using mainBookBlogMvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace mainBookBlogMvc.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string filterString)
        {
            var books = _context.Books.ToList();
            switch (filterString)
            {
                case "title":
                    books = _context.Books.OrderBy(b => b.Title).ToList();
                    break;
                case "author":
                    books = _context.Books.OrderBy(b => b.AuthorName).ToList();
                    break;
                case "publisher":
                    books = _context.Books.OrderBy(b => b.Publisher).ToList();
                    break;
                case "slider":
                    books = _context.Books.OrderByDescending(b => b.InSlider).ToList();
                    break;
                case "date":
                    books = _context.Books.OrderByDescending(b => b.CreatedAt).ToList();
                    break;
                default:
                    break;
            }
            return View(books);
        }
    }
}
