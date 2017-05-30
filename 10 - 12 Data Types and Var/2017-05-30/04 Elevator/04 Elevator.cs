using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double carry = Math.Ceiling(people / capacity);
            Console.WriteLine($"{carry:f0}");
        }
    }
}