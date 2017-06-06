using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle": TriangleOrRectangle(type); break;
                case "rectangle": TriangleOrRectangle(type); break;
                case "square": SquareOrRectangle(type); break;
                case "circle": SquareOrRectangle(type); break;
            }

        }

        static void TriangleOrRectangle(string type)
        {
            decimal one = decimal.Parse(Console.ReadLine());
            decimal two = decimal.Parse(Console.ReadLine());

            if (type == "triangle")
            {
                Console.WriteLine("{0:f2}", one * two / 2);
            }
            else
            {
                Console.WriteLine("{0:f2}", one * two);
            }
        }

        static void SquareOrRectangle(string type)
        {
            double one = double.Parse(Console.ReadLine());
            if (type == "square")
            {
                Console.WriteLine("{0:f2}", one * one);
            }
            else
            {
                Console.WriteLine("{0:f2}", Math.PI * one * one);
            }
        }
    }
}