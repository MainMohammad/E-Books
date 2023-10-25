using E_Books.Data;
using E_Books.Data.Services;
using E_Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace E_Books.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsServices _service;
        public AuthorsController(IAuthorsServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _service.GetAll();
            return View(authors);
        }

        // Authors/Get...
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Age,Biography,ProfileUrl")] Author author)
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
                return View("Empty");
            return View(author);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var author_for_edit = await _service.GetByIdAsync(Id);
            if (author_for_edit == null)
                return View("Empty");

            return View(author_for_edit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Name,Age,Biography,ProfileUrl")]Author newAuthor)
        {
            if (!ModelState.IsValid)
                return View(newAuthor);
            await _service.UpdateAsync(Id, newAuthor);
            return RedirectToAction(nameof(Details));
        }
    }
}
