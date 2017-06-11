using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_AEN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> lineOfDigits = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int cycle = 1; cycle < lineOfDigits.Count; cycle++)
            {
                if (lineOfDigits[cycle] == lineOfDigits[cycle - 1])
                {
                    lineOfDigits[cycle] += lineOfDigits[cycle];
                    lineOfDigits.RemoveAt(cycle - 1);
                    cycle = 0;
                }
            }

            Console.WriteLine(string.Join(" ", lineOfDigits));

        }
    }
}