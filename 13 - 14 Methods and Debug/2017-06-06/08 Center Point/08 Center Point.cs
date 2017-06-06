using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal xOne = decimal.Parse(Console.ReadLine());
            decimal yOne = decimal.Parse(Console.ReadLine());
            decimal xTwo = decimal.Parse(Console.ReadLine());
            decimal yTwo = decimal.Parse(Console.ReadLine());

            decimal topSum, botSum;

            BiggerMethod(xOne, yOne, xTwo, yTwo, out topSum, out botSum);

            PrintingMethod(xOne, yOne, xTwo, yTwo, topSum, botSum);
        }

        private static void BiggerMethod(decimal xOne, decimal yOne, decimal xTwo, decimal yTwo, out decimal topSum, out decimal botSum)
        {
            topSum = Math.Abs(xOne) + Math.Abs(yOne);
            botSum = Math.Abs(xTwo) + Math.Abs(yTwo);
        }

        private static void PrintingMethod(decimal xOne, decimal yOne, decimal xTwo, decimal yTwo, decimal topSum, decimal botSum)
        {
            if (topSum < botSum)
            {
                Console.WriteLine($"({xOne}, {yOne})");
            }
            else if (botSum < topSum)
            {
                Console.WriteLine($"({xTwo}, {yTwo})");
            }
            else if (topSum == botSum)
            {
                Console.WriteLine($"({xOne}, {yOne})");
            }
        }
    }
}