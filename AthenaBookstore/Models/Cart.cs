using System.Collections.Generic;
using System.Linq;


namespace AthenaBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        // Method to add an item to the cart

        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            } 
            else
            {
                line.Quantity += quantity;
            }
            
        }

        //Removing a line
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(l => l.Book.BookId == book.BookId);

        // Compute all the values of the lines
        public double ComputeTotalValue() =>
            Lines.Sum(e => e.Book.Price * e.Quantity);

        // Clear lines
        public virtual void Clear() => Lines.Clear();

    }
    // Class defining a Cart Line item
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
