using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SMMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int[] answer = new int[limit];

            for (int cycle = 0; cycle < limit; cycle++)
            {
                answer[cycle] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {answer.Sum()}");
            Console.WriteLine($"Min = {answer.Min()}");
            Console.WriteLine($"Max = {answer.Max()}");
            Console.WriteLine($"Average = {answer.Average()}");
        }
    }
}