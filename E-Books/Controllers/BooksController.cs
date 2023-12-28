using E_Books.Data.Services;
using E_Books.Data.ViewModels;
using E_Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;

namespace E_Books.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksServices _service;
        public BooksController(IBooksServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 12;
            var books = await _service.GetPageAsync(pageNumber ?? 1, pageSize);
            ViewData["TotalPages"] = await _service.TotalPages(pageSize);
            ViewData["PageIndex"] = pageNumber ?? 1;
            return View(books);
        }

        public async Task<IActionResult> Search(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return RedirectToAction(nameof(Index));
            var result = await _service.SearchAsync(searchString);
            if (result.IsNullOrEmpty())
                return View("NotFound");
            return View(result);
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

        public async Task<IActionResult> Edit(int Id)
        {
            var bookDetails = await _service.GetBookById(Id);

            if (bookDetails == null)
                return View("NotFound");

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Title = bookDetails.Title,
                PublishDate = bookDetails.PublishDate,
                Price = bookDetails.Price,
                Summary = bookDetails.Summary,
                BookCover = bookDetails.BookCover,
                Genre = bookDetails.Genre,
                AuthorIds = bookDetails.Authors_Books.Select(n => n.AuthorId).ToList(),
                BookStoreIds = bookDetails.BookStores_Books.Select(n => n.BookStoreId).ToList(),
                PublisherId = bookDetails.PublisherId,
            };

            var bookDropDownData = await _service.GetNewBookDropdownVals();

            ViewBag.Authors = new SelectList(bookDropDownData.Authors, "Id", "Name");
            ViewBag.Publishers = new SelectList(bookDropDownData.Publishers, "Id", "Name");
            ViewBag.BookStores = new SelectList(bookDropDownData.BookStores, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, NewBookVM book)
        {
            if (Id != book.Id)
                return View("NotFound");

            if(!ModelState.IsValid)
            {
                var bookDropDownData = await _service.GetNewBookDropdownVals();

                ViewBag.Authors = new SelectList(bookDropDownData.Authors, "Id", "Name");
                ViewBag.Publishers = new SelectList(bookDropDownData.Publishers, "Id", "Name");
                ViewBag.BookStores = new SelectList(bookDropDownData.BookStores, "Id", "Name");

                return View(book);
            }

            await _service.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var book_to_delete = await _service.GetBookById(Id);
            if(book_to_delete == null)
                return View("NotFound");
            return View(book_to_delete);
        }

        [HttpPost,  ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var book_to_delete = await _service.GetBookById(Id);
            if (book_to_delete == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}