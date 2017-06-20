using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Book_Lb_Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            var currentBookLine = new Library();

            currentBookLine.booksArchive = new List<Book>();

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                string[] inputLine = Console.ReadLine().Split();

                currentBookLine.Name = inputLine[1] + " - " + inputLine[0]; //playing with the name as a string

                var letsAddThisBook = new Book()
                {
                    Title = inputLine[0],
                    Author = inputLine[1],
                    Publisher = inputLine[2],
                    ReleaseDate = DateTime.ParseExact(inputLine[3], "d.M.yyyy", CultureInfo.InvariantCulture),
                    ISBN = long.Parse(inputLine[4]),
                    Price = decimal.Parse(inputLine[5])
                };

                currentBookLine.booksArchive.Add(letsAddThisBook);
            }

            var dateToCheck = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var wtf in currentBookLine.booksArchive
                .Where(x => x.ReleaseDate > dateToCheck)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title))
            {
                Console.WriteLine($"{wtf.Title} -> {wtf.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> booksArchive { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBN { get; set; }
        public decimal Price { get; set; }
    }
}