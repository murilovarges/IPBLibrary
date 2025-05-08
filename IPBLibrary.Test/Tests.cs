using System.Diagnostics;
using System.Text.Json;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.Test
{
    [TestClass]
    public sealed class Tests
    {
        [TestMethod]
        public void TestMethodBook()
        {
            var bookRepository = new Repository<Book>("books.json");
            var newBook = new Book
            {
                Id = 1,
                Title = "C# Programming",
                Author = new Author { Name = "John Doe" },
                ISBN = "1234567890",
                PublishedDate = DateTime.Now,
                Genre = "Programming"
            };
            bookRepository.Add(newBook);

            newBook = new Book
            {
                Id = 1,
                Title = "C# Por Murilo",
                Author = new Author { Name = "Murilo Varges", DateOfBirth = new DateTime(1984,07,13)},
                ISBN = "1234567890",
                PublishedDate = DateTime.Now,
                Genre = "Programming"
            };
            bookRepository.Add(newBook);
            var books = bookRepository.GetAll();

            Debug.WriteLine($"Total books: {books.Count}");
            Debug.WriteLine(JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
