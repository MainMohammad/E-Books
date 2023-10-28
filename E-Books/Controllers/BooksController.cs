using E_Books.Data;
using E_Books.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksServices _service;
        public BooksController(IBooksServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _service.GetAllAsync();
            return View(books);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var book = await _service.GetBookById(Id);
            if (book == null)
                return View("NotFound");
            return View(book);
        }
    }
}
