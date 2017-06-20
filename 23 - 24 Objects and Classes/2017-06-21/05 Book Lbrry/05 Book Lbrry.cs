using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05_Book_Lbrry
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

            foreach (var wtf in currentBookLine.booksArchive
                .GroupBy(x => x.Author)
                .OrderByDescending(x => x.Sum(y => y.Price))
                .ThenBy(z => z.Key)) //nice going there, SoftUni!
            {
                Console.WriteLine($"{wtf.Key} -> {wtf.Sum(x => x.Price):f2}");
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