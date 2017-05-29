using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            decimal priceTotal = 0M;


            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else if (groupSize <= 50)
            {
                priceTotal += 2500;
                Console.WriteLine("We can offer you the Small Hall");
            }
            else if (groupSize <= 100)
            {
                priceTotal += 5000;
                Console.WriteLine("We can offer you the Terrace");
            }
            else if (groupSize <= 120)
            {
                priceTotal += 7500;
                Console.WriteLine("We can offer you the Great Hall");
            }

            if (package == "normal")
            {
                priceTotal += 500;
                priceTotal = priceTotal - (priceTotal * 0.05M);
            }
            else if (package == "gold")
            {
                priceTotal += 750;
                priceTotal = priceTotal - (priceTotal * 0.1M);
            }
            else if (package == "platinum")
            {
                priceTotal += 1000;
                priceTotal = priceTotal - (priceTotal * 0.15M);
            }

            if (groupSize <= 120)
            {
            decimal perPerson = priceTotal / groupSize;
            Console.WriteLine("The price per person is {0:f2}$", perPerson);
            }
        }
    }
}