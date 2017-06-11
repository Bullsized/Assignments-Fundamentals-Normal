using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> solution = new List<int>();

            for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
            {
                if (Math.Sqrt(lineOfDigits[cycle]) == (int)Math.Sqrt(lineOfDigits[cycle]))
                {
                    solution.Add(lineOfDigits[cycle]);
                }
            }

            solution.Sort();
            solution.Reverse();

            Console.WriteLine(string.Join(" ", solution));
        }
    }
}