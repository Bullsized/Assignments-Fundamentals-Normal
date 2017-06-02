using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string answer = string.Empty;
            decimal calculatedVolume = 0;
            decimal biggestVolume = decimal.MinValue;


            for (int cycle = 0; cycle < n; cycle++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                decimal height = decimal.Parse(Console.ReadLine());

                calculatedVolume = (decimal)Math.PI * radius * radius * height;

                if (calculatedVolume > biggestVolume)
                {
                    answer = model;
                    biggestVolume = calculatedVolume;
                }
            }
            Console.WriteLine(answer);
        }
    }
}