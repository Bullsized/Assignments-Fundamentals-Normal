using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Practice_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            char four = char.Parse(Console.ReadLine());
            string five = Console.ReadLine();

            Console.WriteLine($"{one}\n{two}\n{three}\n{four}\n{five}");
        }
    }
}