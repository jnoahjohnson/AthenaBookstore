using AthenaBookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthenaBookstore.Views.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookstoreRepository _repository;

        public NavigationMenuViewComponent(IBookstoreRepository repo)
        {
            _repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            // Component to return all the different categories. This is reflected in Views/Shared/Components/NavigationMenu
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
