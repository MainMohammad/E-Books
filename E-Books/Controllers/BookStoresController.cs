using E_Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Controllers
{
    public class BookStoresController : Controller
    {
        private readonly AppDbContext _context;
        public BookStoresController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var book_stores = await _context.BookStores.ToListAsync();
            return View(book_stores);
        }
    }
}
