using E_Books.Data.Services;
using E_Books.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Dynamic;

namespace E_Books.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IPublishersServices _publishersService;
        private readonly IBooksServices _booksService;
        public HomeController(IPublishersServices publishersService, IBooksServices booksService)
        {
            _publishersService = publishersService;
            _booksService = booksService;
        }

        public async Task<IActionResult> Index()
        {
            var randpublisher = await getRandomPublisher();
            dynamic myModel = new ExpandoObject();
            myModel.Publisher = randpublisher[0];
            int id = Convert.ToInt32(randpublisher[1]);
            var books = await _booksService.GetBooksByPublisherId(id);
            myModel.Books = books;
            return View(myModel);
        }

        private async Task<List<object>> getRandomPublisher()
        {
            var Ids = new List<int>();
            Random randId = new Random();
            var Publishers = await _publishersService.GetAllAsync();
            foreach(var p in Publishers)
            {
                Ids.Add(p.Id);
            }
            int Id = randId.Next(Ids.Count);
            Publisher publisher = await _publishersService.GetByIdAsync(Id);
            var ReturnList = new List<object> { publisher, Id };
            return ReturnList;
        }
    }
}