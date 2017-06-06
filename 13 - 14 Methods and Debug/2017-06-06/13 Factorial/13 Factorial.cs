using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (int i = input; i > 0; i--)
            {
                fact *= i;
            }

            Console.WriteLine(fact);

        }
    }
}