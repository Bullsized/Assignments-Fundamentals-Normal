using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numOfItems = int.Parse(Console.ReadLine());
            decimal moneyLeft = budget;
            decimal subtotal = 0;
            for (int cycle = 0; cycle < numOfItems; cycle++)
            {
                string item = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                decimal count = decimal.Parse(Console.ReadLine());

                if (count > 1)
                {
                    Console.WriteLine($"Adding {count} {item}s to cart.");
                    subtotal += count * price;
                }
                else
                {
                    Console.WriteLine($"Adding {count} {item} to cart.");
                    subtotal += count * price;
                }
            }

            if (subtotal < budget)
            {
                Console.WriteLine($"Subtotal: ${subtotal:f2}");
                Console.WriteLine($"Money left: ${budget - subtotal:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:f2}");
                Console.WriteLine($"Not enough. We need ${subtotal - budget:f2} more.");
            }
        }
    }
}