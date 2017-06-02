using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int cycle = 0; cycle < n; cycle++)
            {
                char toAdd = char.Parse(Console.ReadLine());
                sum += toAdd;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}