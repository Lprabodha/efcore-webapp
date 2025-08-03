using c_webproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace c_webproject.Controllers
{
    public class BookController : Controller
    {

        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var books = _context.books.ToList();

            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _context.books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        //GET: Book/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.books.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}
