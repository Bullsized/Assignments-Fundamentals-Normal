using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputNum = decimal.Parse(Console.ReadLine());

            if (inputNum % 1 != 0)
            {
                Console.WriteLine("Rainy");
            }
            else if (sbyte.MinValue <= inputNum && inputNum <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (int.MinValue <= inputNum && inputNum <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.MinValue <= inputNum && inputNum <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}