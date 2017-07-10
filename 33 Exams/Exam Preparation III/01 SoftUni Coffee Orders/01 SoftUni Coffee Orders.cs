using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _01_SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime takeTheMonth = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsules = decimal.Parse(Console.ReadLine());

                decimal daysInMonth = DateTime.DaysInMonth(takeTheMonth.Year, takeTheMonth.Month);

                decimal singlePrice = daysInMonth * capsules * price;
                totalPrice += singlePrice;

                Console.WriteLine($"The price for the coffee is: ${singlePrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}