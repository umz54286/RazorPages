using Microsoft.EntityFrameworkCore;
using RazorPages.Data;

namespace RazorPages.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPagesBookContext");
                }

                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        ProductNo = "X001",
                        ProductName = "BOOK1",
                        Type = "TypeA",
                        Price = 0,
                        PublicationDate = DateTime.Parse("1911-1-1"),
                        Rating = "C"
                    },

                    new Book
                    {
                        ProductNo = "X002",
                        ProductName = "BOOK2",
                        Type = "TypeB",
                        Price = 0,
                        PublicationDate = DateTime.Parse("1911-1-1"),
                        Rating = "C"
                    },

                    new Book
                    {
                        ProductNo = "X003",
                        ProductName = "BOOK3",
                        Type = "TypeC",
                        Price = 0,
                        PublicationDate = DateTime.Parse("1911-1-1"),
                        Rating = "C"
                    },

                    new Book
                    {
                        ProductNo = "X004",
                        ProductName = "BOOK4",
                        Type = "TypeD",
                        Price = 0,
                        PublicationDate = DateTime.Parse("1911-1-1"),
                        Rating = "C"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
