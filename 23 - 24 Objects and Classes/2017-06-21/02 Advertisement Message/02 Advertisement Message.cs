using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
                        { "Excellent product.", "Such a great product.",
                            "I always use that product.", "Best product of its category.",
                            "Exceptional product.", "I can’t live without this product."};

            string[] events = new string[]
                { "Now I feel good.", "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = new string[]
                { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = new string[]
                { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random randomString = new Random();

            int phrasesIndex = randomString.Next(phrases.Length);
            int eventsIndex = randomString.Next(events.Length);
            int authorsIndex = randomString.Next(authors.Length);
            int citiesIndex = randomString.Next(cities.Length);

            Console.WriteLine("{0} {1} {2} - {3}", 
                phrases[phrasesIndex],
                events[eventsIndex],
                authors[authorsIndex],
                cities[citiesIndex]);
        }
    }
}