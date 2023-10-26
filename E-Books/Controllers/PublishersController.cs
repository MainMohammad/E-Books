using E_Books.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDbContext _context;
        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var publishers = await _context.Publishers.ToListAsync();
            return View();
        }
    }
}
