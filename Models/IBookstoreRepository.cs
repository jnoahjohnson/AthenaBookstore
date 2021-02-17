using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Interface defining the Bookstore Repository that will be implemented in EFBookstore Repository

namespace AthenaBookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
