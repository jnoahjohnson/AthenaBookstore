using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AthenaBookstore.Infrastructure;
using AthenaBookstore.Models;
using System.Linq;

// Page model class
// Defines handler methods that are invoked for different types of HTTP requests

namespace AthenaBookstore.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepository _repository;

        public CartModel(IBookstoreRepository repo, Cart cartService)
        {
            _repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = _repository.Books
                .FirstOrDefault(b => b.BookId == bookId);
            Cart.AddItem(book, 1);
            return RedirectToPage(new { returnUrl = returnUrl });

        }

        // New method for when a user removes a line item (clicks on the remove button)
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
