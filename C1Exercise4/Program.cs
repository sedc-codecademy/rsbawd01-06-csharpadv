namespace C1Exercise4
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            /*
          
            Exercise 4: LINQ
            
            Write a C# program that performs the following actions using LINQ:
            
            Filter the list of books to include only those written by "Author1".
            Sort the list of books by their publication year in ascending order.
            Project the list of books into a new list containing only their titles.
            Finally, display the titles of the filtered and sorted books using a loop or any suitable method.*/

            List<Book> books = new List<Book>
            {
                new Book { Title = "Book1", Author = "Author1", Year = 2010 },
                new Book { Title = "Book2", Author = "Author2", Year = 2005 },
                new Book { Title = "Book3", Author = "Author3", Year = 2018 },
                new Book { Title = "Book4", Author = "Author1", Year = 2020 }
            };

            List<string> filteredBooks = books
                .Where(book => book.Author == "Author1")
                .OrderBy(book => book.Year)
                .Select(book => book.Title)
                .ToList();

            foreach (var title in filteredBooks)
                Console.WriteLine(title);
        }
    }
}