using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tourist_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string measurement = Console.ReadLine();
            decimal howMuch = decimal.Parse(Console.ReadLine());

            switch (measurement)
            {
                case "miles": Console.WriteLine($"{howMuch} {measurement} = {howMuch*1.6m:f2} kilometers"); break;
                case "inches": Console.WriteLine($"{howMuch} {measurement} = {howMuch * 2.54m:f2} centimeters"); break;
                case "feet": Console.WriteLine($"{howMuch} {measurement} = {howMuch * 30m:f2} centimeters"); break;
                case "yards": Console.WriteLine($"{howMuch} {measurement} = {howMuch * 0.91m:f2} meters"); break;
                case "gallons": Console.WriteLine($"{howMuch} {measurement} = {howMuch * 3.8m:f2} liters"); break;
            }
        }
    }
}