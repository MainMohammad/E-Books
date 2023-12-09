using E_Books.Data.Services;
using E_Books.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Books.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsServices _service;
        public AuthorsController(IAuthorsServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 5;
            var authors = await _service.GetAllAsync();
            var data = Pager<Author>.Create(authors.ToList(), pageNumber ?? 1, pageSize);
            ViewData["curPage"] = data;
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Age,Biography,ProfileURL")] Author author)
        {
            if(!ModelState.IsValid)
                return View(author);
            await _service.AddAsync(author);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var author = await _service.GetByIdAsync(Id);
            if (author == null)
                return View("NotFound");
            return View(author);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var author_for_edit = await _service.GetByIdAsync(Id);
            if (author_for_edit == null)
                return View("NotFound");

            return View(author_for_edit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,Name,Age,Biography,ProfileURL")]Author newAuthor)
        {
            if (!ModelState.IsValid)
                return View(newAuthor);
            await _service.UpdateAsync(Id, newAuthor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var author_to_delete = await _service.GetByIdAsync(Id);
            if (author_to_delete == null)
                return View("NotFound");
            return View(author_to_delete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var author_to_delete = await _service.GetByIdAsync(Id);
            if (author_to_delete == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
