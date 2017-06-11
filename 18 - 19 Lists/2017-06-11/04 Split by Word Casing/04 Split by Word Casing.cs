using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineOfStrings = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> upperWords = new List<string>();
            List<string> lowerWords = new List<string>();
            List<string> mixedWords = new List<string>();
            

            for (int cycle = 0; cycle < lineOfStrings.Count; cycle++)
            {
                if (lineOfStrings[cycle].ToUpper().Equals(lineOfStrings[cycle]))
                {
                    upperWords.Add(lineOfStrings[cycle]);
                }
                else if (lineOfStrings[cycle].ToLower().Equals(lineOfStrings[cycle]))
                {
                    lowerWords.Add(lineOfStrings[cycle]);
                }
                else
                {
                    mixedWords.Add(lineOfStrings[cycle]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperWords)}");
        }
    }
}