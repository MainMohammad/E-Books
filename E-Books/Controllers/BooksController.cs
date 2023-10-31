using E_Books.Data;
using E_Books.Data.Services;
using E_Books.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<IActionResult> Search(string searchString)
        {
            var books = await _service.GetAllAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredBooks = books.Where(b => b.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase) || b.Summary.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                return View("Index", filteredBooks);
            }
            return View("Index", books);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var book = await _service.GetBookById(Id);
            if (book == null)
                return View("NotFound");
            return View(book);
        }

        public async Task<IActionResult> Create()
        {
            var bookDropDownData = await _service.GetNewBookDropdownVals();
            ViewBag.PublisherId = new SelectList(bookDropDownData.Publishers, "Id", "Name");
            ViewBag.AuthorIds = new SelectList(bookDropDownData.Authors, "Id", "Name");
            ViewBag.BookStoreIds = new SelectList(bookDropDownData.BookStores, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM book)
        {
            if (!ModelState.IsValid)
            {
                var bookDropDownData = await _service.GetNewBookDropdownVals();
                ViewBag.PublisherId = new SelectList(bookDropDownData.Publishers, "Id", "Name");
                ViewBag.AuthorIds = new SelectList(bookDropDownData.Authors, "Id", "Name");
                ViewBag.BookStoreIds = new SelectList(bookDropDownData.BookStores, "Id", "Name");
                return View(book);
            }
            await _service.AddNewBook(book);
            return RedirectToAction(nameof(Index));
        }
    }
}
