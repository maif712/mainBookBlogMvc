using mainBookBlogMvc.Data;
using mainBookBlogMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace mainBookBlogMvc.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: book/create
        public IActionResult Create()
        {
            return View();
        }

        // POST: book/create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index", "Dashboard");
            }

            return View();
        }


        // GET: book/edit
        public IActionResult Edit(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }

        // POST: book/edit
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Update(book);
                _context.SaveChanges();
                return RedirectToAction("Index", "Dashboard");
            }

            return View();
        }

        // POST: book/delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var bookToDelete = _context.Books.Find(id);
            if(bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Dashboard");
        }

        // GET: book/detail
        public IActionResult Detail(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }

        // GET: book/search?bookTitle=string
        public IActionResult Search(string bookTitle)
        {
            var books = _context.Books.Where(book => book.Title.Contains(bookTitle.ToLower())).ToList();
            return View(books);
        }
    }
}
