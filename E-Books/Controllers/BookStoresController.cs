using E_Books.Data;
using E_Books.Data.Services;
using E_Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Controllers
{
    public class BookStoresController : Controller
    {
        private readonly IBookStoresServices _service;
        public BookStoresController(IBookStoresServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var bookStores = await _service.GetAllAsync();
            return View(bookStores);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Address,Telephone,LogoURL")] BookStore bookStore)
        {
            if (!ModelState.IsValid)
                return View(bookStore);
            await _service.AddAsync(bookStore);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var bookStore = await _service.GetByIdAsync(Id);
            if (bookStore == null)
                return View("NotFound");
            return View(bookStore);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var bookStore_for_edit = await _service.GetByIdAsync(Id);
            if (bookStore_for_edit == null)
                return View("NotFound");

            return View(bookStore_for_edit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Name,Address,Telephone,LogoURL")] BookStore bookStore)
        {
            if (!ModelState.IsValid)
                return View(bookStore);
            await _service.UpdateAsync(Id, bookStore);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var bookStore_to_delete = await _service.GetByIdAsync(Id);
            if (bookStore_to_delete == null)
                return View("NotFound");
            return View(bookStore_to_delete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var bookStore_to_delete = await _service.GetByIdAsync(Id);
            if (bookStore_to_delete == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
