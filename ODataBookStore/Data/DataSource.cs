using ODataBookStore.Models;

namespace ODataBookStore.Data
{
    public static class DataSource
    {
        private static IList<Book> listBooks {  get; set; }
        public static IList<Book> GetBooks()
        {
            if (listBooks != null)
            {
                return listBooks;
            }
            listBooks = new List<Book>();
            Book book = new Book()
            {
                Id = 1,

                ISBN = "978-0-321-87758-1",
                Title = "Essential C#5.0",
                Author="Mark Michaelis",
                Price= 59.99m,
                Location = new Address
                {
                    City = "HCM City",
                    Street = "D2, Thu Duc Distrist"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Addison-Wesley",
                    Category= Category.Book
                }
            };
            listBooks.Add(book);
            Book book2 = new Book()
            {
                Id = 2,
                ISBN = "978-0-596-52068-7",
                Title = "Learning Python",
                Author = "Mark Lutz",
                Price = 64.95m,
                Location = new Address
                {
                    City = "San Francisco",
                    Street = "Market Street"
                },
                Press = new Press
                {
                    Id = 2,
                    Name = "O'Reilly Media",
                    Category = Category.Book
                }
            };

            Book book3 = new Book()
            {
                Id = 3,
                ISBN = "978-0-13-235088-4",
                Title = "Clean Code",
                Author = "Robert C. Martin",
                Price = 49.99m,
                Location = new Address
                {
                    City = "New York",
                    Street = "5th Avenue"
                },
                Press = new Press
                {
                    Id = 3,
                    Name = "Prentice Hall",
                    Category = Category.Book
                }
            };

            Book book4 = new Book()
            {
                Id = 4,
                ISBN = "978-0-07-161586-4",
                Title = "The Art of Computer Programming",
                Author = "Donald Knuth",
                Price = 199.99m,
                Location = new Address
                {
                    City = "Hanoi",
                    Street = "Hoan Kiem District"
                },
                Press = new Press
                {
                    Id = 4,
                    Name = "Addison-Wesley",
                    Category = Category.Book
                }
            };

            Book book5 = new Book()
            {
                Id = 5,
                ISBN = "978-1-491-99488-2",
                Title = "JavaScript: The Good Parts",
                Author = "Douglas Crockford",
                Price = 34.99m,
                Location = new Address
                {
                    City = "London",
                    Street = "Oxford Street"
                },
                Press = new Press
                {
                    Id = 5,
                    Name = "O'Reilly Media",
                    Category = Category.Book
                }
            };
            listBooks.Add(book2);
            listBooks.Add(book3);
            listBooks.Add(book4);
            listBooks.Add(book5);
            return listBooks;
        }
    }
}
