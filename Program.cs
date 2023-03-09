using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDatabase
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }

    class Program
    {
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. List all books");
                Console.WriteLine("3. Search for a book");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        ListBooks();
                        break;
                    case "3":
                        SearchBooks();
                        break;
                    case "4":
                        return;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            books.Add(new Book(title, author, year));

            Console.WriteLine();
            Console.WriteLine("Book added successfully.");
            Console.WriteLine();
        }

        static void ListBooks()
        {
            Console.WriteLine("Title\t\tAuthor\t\tYear");
            Console.WriteLine("---------------------------------------------");

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title + "\t\t" + book.Author + "\t\t" + book.Year);
            }

            Console.WriteLine();
        }

        static void SearchBooks()
        {
            Console.Write("Enter the search term: ");
            string searchTerm = Console.ReadLine().ToLower();

            Console.WriteLine();
            Console.WriteLine("Title\t\tAuthor\t\tYear");
            Console.WriteLine("---------------------------------------------");

            bool found = false;
            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(searchTerm) || book.Author.ToLower().Contains(searchTerm))
                {
                    Console.WriteLine(book.Title + "\t\t" + book.Author + "\t\t" + book.Year);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found.");
            }

            Console.WriteLine();
        }
    }
}
