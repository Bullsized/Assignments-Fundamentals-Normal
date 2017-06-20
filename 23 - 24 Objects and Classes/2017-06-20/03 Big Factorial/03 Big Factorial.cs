using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());

            BigInteger solution = 1;

            for (int cycle = 1; cycle <= factorial; cycle++)
            {
                solution *= cycle;
            }

            Console.WriteLine(solution);
        }
    }
}
