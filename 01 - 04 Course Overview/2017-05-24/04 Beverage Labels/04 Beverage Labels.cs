using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double calcEnergy = (volume * energy) / 100d;
            double calcSugar = (volume * sugar) / 100d;

            Console.WriteLine($"{volume}ml {drink}:\n{calcEnergy}kcal, {calcSugar}g sugars");
        }
    }
}