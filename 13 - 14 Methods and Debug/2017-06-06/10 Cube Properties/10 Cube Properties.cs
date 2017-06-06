using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face": Console.WriteLine("{0:f2}", Math.Sqrt(2 * Math.Pow(sideOfTheCube, 2))); break;
                case "space": Console.WriteLine("{0:f2}", Math.Sqrt(3 * Math.Pow(sideOfTheCube, 2))); break;
                case "volume": Console.WriteLine("{0:f2}", Math.Pow(sideOfTheCube, 3)); break;
                case "area": Console.WriteLine("{0:f2}", 6 * Math.Pow(sideOfTheCube, 2)); break;
            }

        }
    }
}