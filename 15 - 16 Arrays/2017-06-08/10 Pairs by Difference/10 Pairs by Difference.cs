using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int cycle1 = 0; cycle1 < listOfDigits.Length; cycle1++)
            {
                for (int cycle2 = 0; cycle2 < listOfDigits.Length; cycle2++)
                {
                    if ((listOfDigits[cycle1] - listOfDigits[cycle2]) == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}