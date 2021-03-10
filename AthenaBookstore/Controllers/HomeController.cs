using AthenaBookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AthenaBookstore.Models.ViewModels;

namespace AthenaBookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {
            // Pass in the repository books
            // Also, change this in the future back into the index, for the sake of the continued project I didn't want to change too much and then have to change it back
            // There is also now pagination to get the number of items per each page
            // Additinoally, there is the num items based on the category that is fiiltered
            return View("ViewBooks", new BookListViewModel
            {
                Books = _repository.Books.Where(p => category == null || p.Category == category).OrderBy(p => p.BookId).Skip((pageNum - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ?
                        _repository.Books.Count() :
                        _repository.Books.Where(e =>
                            e.Category == category).Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
