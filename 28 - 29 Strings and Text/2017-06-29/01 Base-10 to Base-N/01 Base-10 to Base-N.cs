using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] lineOfDigits = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseToConvert = lineOfDigits[0];
            BigInteger digitToConvert = lineOfDigits[1];

            List<BigInteger> solution = new List<BigInteger>();

            while (digitToConvert > 0)
            {
                BigInteger remainder = digitToConvert % baseToConvert;
                solution.Add(remainder);
                digitToConvert /= baseToConvert;
            }

            solution.Reverse();
            Console.WriteLine(string.Join("", solution));
        }
    }
}