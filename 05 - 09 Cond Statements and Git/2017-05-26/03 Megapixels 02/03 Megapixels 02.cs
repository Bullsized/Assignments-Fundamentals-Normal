using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Megapixels_02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            decimal scaled = (width * height ) / 1000000M;

            Console.WriteLine($"{width}x{height} => {Math.Round(scaled, 1)}MP");
        }
    }
}