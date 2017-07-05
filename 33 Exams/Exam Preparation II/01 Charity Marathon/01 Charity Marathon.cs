using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days01 = int.Parse(Console.ReadLine());
            int runners02 = int.Parse(Console.ReadLine());
            int laps03 = int.Parse(Console.ReadLine());
            int length04 = int.Parse(Console.ReadLine());
            int capacity05 = int.Parse(Console.ReadLine());
            decimal money06 = decimal.Parse(Console.ReadLine());

            BigInteger numberOfRunners07 = capacity05 * days01;

            if (numberOfRunners07 >= runners02)
            {
                numberOfRunners07 = runners02;
            }

            BigInteger totalMeters08 = numberOfRunners07 * laps03 * length04;

            BigInteger totalKM09 = totalMeters08 / 1000;

            var answer10 = (decimal)totalKM09 * money06; //of course here will be the shit.

            Console.WriteLine("Money raised: {0:f2}", answer10);
        }
    }
}