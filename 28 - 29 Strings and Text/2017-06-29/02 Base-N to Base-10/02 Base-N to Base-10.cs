using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOfDigits = Console.ReadLine().Split();
            BigInteger baseToConvert = BigInteger.Parse(lineOfDigits[0]);
            char[] charredDigit = lineOfDigits[1].ToCharArray();
            List<string> reversedIntList = new List<string>();
            BigInteger sum = 0;

            for (int cycle2 = charredDigit.Length - 1; cycle2 >= 0; cycle2--)
            {
                reversedIntList.Add(charredDigit[cycle2].ToString());
            }

            for (int cycle = 0; cycle < reversedIntList.Count; cycle++)
            {
                BigInteger digitToMultiply = BigInteger.Parse(reversedIntList[cycle]);
                sum += digitToMultiply * (BigInteger)Math.Pow((double)baseToConvert, cycle);
            }

            Console.WriteLine(sum);
        }
    }
}