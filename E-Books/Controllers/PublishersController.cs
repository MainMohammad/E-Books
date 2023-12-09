using E_Books.Data.Services;
using E_Books.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Books.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublishersServices _service;
        public PublishersController(IPublishersServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 5;
            var publishers = await _service.GetAllAsync();
            var data = Pager<Publisher>.Create(publishers.ToList(), pageNumber ?? 1, pageSize);
            ViewData["curPage"] = data;
            return View(publishers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Address,Email,LogoURL")] Publisher publisher)
        {
            if (!ModelState.IsValid)
                return View(publisher);
            await _service.AddAsync(publisher);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var publisher = await _service.GetByIdAsync(Id);
            if (publisher == null)
                return View("NotFound");
            return View(publisher);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var publisher_for_edit = await _service.GetByIdAsync(Id);
            if (publisher_for_edit == null)
                return View("NotFound");

            return View(publisher_for_edit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,Name,Description,Address,Email,LogoURL")] Publisher publisher)
        {
            if (!ModelState.IsValid)
                return View(publisher);
            await _service.UpdateAsync(Id, publisher);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var publisher_to_delete = await _service.GetByIdAsync(Id);
            if (publisher_to_delete == null)
                return View("NotFound");
            return View(publisher_to_delete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var publisher_to_delete = await _service.GetByIdAsync(Id);
            if (publisher_to_delete == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
