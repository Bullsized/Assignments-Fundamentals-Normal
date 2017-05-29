using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int meterHealth = int.Parse(Console.ReadLine());
            int limitHealth = int.Parse(Console.ReadLine());
            int meterEnergy = int.Parse(Console.ReadLine());
            int limitEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', meterHealth),
                new string('.', limitHealth - meterHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', meterEnergy),
                new string('.', limitEnergy - meterEnergy));

        }
    }
}