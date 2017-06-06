using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {           
            decimal xOne = decimal.Parse(Console.ReadLine());
            decimal yOne = decimal.Parse(Console.ReadLine());
            decimal xTwo = decimal.Parse(Console.ReadLine());
            decimal yTwo = decimal.Parse(Console.ReadLine());
            decimal xThree = decimal.Parse(Console.ReadLine());
            decimal yThree = decimal.Parse(Console.ReadLine());
            decimal xFour = decimal.Parse(Console.ReadLine());
            decimal yFour = decimal.Parse(Console.ReadLine());

            decimal topSum, botSum;
            decimal thirdSum, fourthSum;

            BiggerMethod(xOne, yOne, xTwo, yTwo, out topSum, out botSum);
            BiggerMethod(xThree, yThree, xFour, yFour, out thirdSum, out fourthSum);

            if (topSum + botSum >= thirdSum + fourthSum)
            {
                if (topSum > botSum)
                {
                    PrintOutput(xOne, yOne, xTwo, yTwo);
                }
                else if (botSum > topSum)
                {
                    PrintOutput(xTwo, yTwo, xOne, yOne);
                }
            }
            else if (thirdSum + fourthSum > topSum + botSum)
            {
                if (thirdSum < fourthSum)
                {
                    PrintOutput(xFour, yFour, xThree, yThree);
                }
                else if (fourthSum < thirdSum)
                {
                    PrintOutput(xThree, yThree, xFour, yFour);
                }
            }
        }

        private static void PrintOutput(decimal xOne, decimal yOne, decimal xTwo, decimal yTwo)
        {
            Console.WriteLine($"({xTwo}, {yTwo})({xOne}, {yOne})");
        }

        private static void BiggerMethod(decimal xOne, decimal yOne, decimal xTwo, decimal yTwo, out decimal topSum, out decimal botSum)
        {
            topSum = Math.Abs(xOne) + Math.Abs(yOne);
            botSum = Math.Abs(xTwo) + Math.Abs(yTwo);
        }
    }
}