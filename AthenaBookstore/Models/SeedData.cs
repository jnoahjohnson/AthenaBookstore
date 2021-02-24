using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthenaBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            // Setup context
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            // Check if there are any pending migrations ini the context
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            // If there are no books in the context
            if(!context.Books.Any())
            {
                // Add seed data
                context.Books.AddRange(

                     // Seed data
                     new Book
                     {
                         Title = "The Way of Kings",
                         AuthorFirstName = "Brandon",
                         AuthorLastName = "Sanderson",
                         Publisher = "Tor",
                         ISBN = "978-0765326355",
                         Classification = "Fiction",
                         Category = "Fantasy",
                         Price = 23.64,
                         NumPages = 1007
                     },
                     new Book
                     {
                         Title = "Ender's Game",
                         AuthorFirstName = "Orson",
                         AuthorMiddleName = "Scott",
                         AuthorLastName = "Card",
                         Publisher = "Tor",
                         ISBN = "978-0765394866",
                         Classification = "Fiction",
                         Category = "Science Fiction",
                         Price = 9.49,
                         NumPages = 324
                     },
                     new Book
                     {
                         Title = "Ready Player One",
                         AuthorFirstName = "Ernest",
                         AuthorLastName = "Cline",
                         Publisher = "Ballantine Books",
                         ISBN = "978-0307887436",
                         Classification = "Fiction",
                         Category = "Science Fiction",
                         Price = 21.48,
                         NumPages = 374
                     },
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumPages = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumPages = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumPages = 864

                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumPages = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumPages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        NumPages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        NumPages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumPages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        NumPages = 642
                    }
                );

                // Save the context
                context.SaveChanges();
            }
        }

    }
}
