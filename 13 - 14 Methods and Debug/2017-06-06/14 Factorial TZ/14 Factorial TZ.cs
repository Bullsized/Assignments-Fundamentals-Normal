using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_Factorial_TZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger fact = 1;
            int zeroCounts = 0;

            for (int i = input; i > 0; i--)
            {
                fact *= i;
            }
            for (int i = 0; i < fact.ToString().Length; i++)
            {
                if (fact % 10 == 0)
                {
                    zeroCounts++;
                    fact /= 10;
                }
                else if (fact % 10 != 0)
                {
                    break;
                }
            }
            Console.WriteLine(zeroCounts);
        }
    }
}