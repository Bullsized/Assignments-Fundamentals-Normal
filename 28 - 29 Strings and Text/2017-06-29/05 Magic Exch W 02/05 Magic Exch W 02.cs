using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Magic_Exch_W_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string firstWord = input[0];
            string secondWord = input[1];

            bool result = AreExchangeable(firstWord, secondWord);

            Console.WriteLine(result.ToString().ToLower());
        }

        public static bool AreExchangeable(string firstWord, string secondWord)
        {
            bool exchengable = false;

            List<char> first = firstWord.ToCharArray().Distinct().ToList();
            List<char> second = secondWord.ToCharArray().Distinct().ToList();

            if (first.Count == second.Count)
            {
                exchengable = true;
            }

            return exchengable;
        }
    }
}