using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07_Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] clues = Console.ReadLine().Split(' ');
                string searchedSymbol = clues[0];
                int searchedCount = int.Parse(clues[1]);

                string pattern = Regex.Escape(searchedSymbol) + @"{" + searchedCount + @",}";
                Regex findHideout = new Regex(pattern);

                var matched = findHideout.Match(map);


                //var regex = new Regex($@"\{searchedCharacter}{{{minimumCount},}}");

                //var match = regex.Match(map);

                //if (match.Success)
                //{
                //    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                //    break;
                //}




                    if (matched.Success)
                {
                    int index = matched.Index;
                    int size = matched.Length;

                    Console.WriteLine($"Hideout found at index {index} and it is with size {size}!");
                    break;
                }
            }
        }
    }
}