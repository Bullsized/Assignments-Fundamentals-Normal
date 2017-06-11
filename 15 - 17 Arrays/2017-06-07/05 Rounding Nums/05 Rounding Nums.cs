using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rounding_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] solution = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            for (int cycle = 0; cycle < solution.Length; cycle++)
            {
                Console.WriteLine($"{solution[cycle]} => {Math.Round(solution[cycle], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}