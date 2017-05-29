using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float numOne = float.Parse(Console.ReadLine());
            float numTwo = float.Parse(Console.ReadLine());

            Console.WriteLine($"{numOne*numTwo:f2}");
        }
    }
}