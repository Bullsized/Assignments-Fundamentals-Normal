using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            int evenValues = 0;
            int oddValues = 0;

            while (Math.Abs(digit) > 0)
            {
                int lastDigit = digit % 10;

                if (lastDigit %2 == 0)
                {
                    evenValues += lastDigit;
                }
                else if (lastDigit %2 != 0)
                {
                    oddValues += lastDigit;
                }

                digit /= 10;
            }

            Console.WriteLine(evenValues * oddValues);
        }
    }
}