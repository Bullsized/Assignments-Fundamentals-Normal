using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}