using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int followingDigits = int.Parse(Console.ReadLine());
            int receivedDigit = 0;
            int totalWater = 0;
            int copy = 0;

            for (int cycle = 0; cycle < followingDigits; cycle++)
            {
                receivedDigit = int.Parse(Console.ReadLine());
                totalWater += receivedDigit;

                if (totalWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    copy += receivedDigit;
                }
            }
            if (totalWater < 255)
            {
            Console.WriteLine(totalWater);
            }
            else
            {
                Console.WriteLine(totalWater - copy);
            }
        }
    }
}