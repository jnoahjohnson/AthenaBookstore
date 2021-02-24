using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Default class to setup the context for the database on the client

namespace AthenaBookstore.Models
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext (DbContextOptions<BookstoreDbContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
