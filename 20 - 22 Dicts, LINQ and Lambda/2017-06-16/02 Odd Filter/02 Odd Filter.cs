using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
            {
                if (lineOfDigits[cycle] % 2 == 1)
                {
                    lineOfDigits.RemoveAt(cycle);
                    cycle--;
                }
            }

            double average = lineOfDigits.Average();

            for (int cycle2 = 0; cycle2 < lineOfDigits.Count; cycle2++)
            {
                if (lineOfDigits[cycle2] > average)
                {
                    lineOfDigits[cycle2]++;
                }
                else
                {
                    lineOfDigits[cycle2]--;
                }
            }

            Console.WriteLine(string.Join(" ", lineOfDigits));
        }
    }
}