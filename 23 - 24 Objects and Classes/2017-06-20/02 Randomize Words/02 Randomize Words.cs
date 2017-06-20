using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOfWords = Console.ReadLine().Split();

            var randomNumGen = new Random();

            string[] randomLineOfWords = lineOfWords.OrderBy(x => randomNumGen.Next()).ToArray(); 
            // if we put ' 0, 4 ' in the Next() brakets, it will randomize only from element 0 to element 4 ~

            foreach (var word in randomLineOfWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}