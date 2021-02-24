using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthenaBookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        // Create a context from the BookstoreDb Context
        private BookstoreDbContext _context;
        
        // Contructor
        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }

        // What was outlined in the interface that this repository needs
        public IQueryable<Book> Books => _context.Books; // Set the Books to the context that was setup in the DbContext
    }
}
