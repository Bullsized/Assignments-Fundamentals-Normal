using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nights = decimal.Parse(Console.ReadLine());

            if (month == "May")
            {
                if (nights > 7)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * (50m * 0.95m));
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
            }
            else if (month == "October")
            {
                if (nights > 7)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * (50m * 0.95m));
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                }
            }
            else if (month == "June")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * (72m * 0.90m));
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
            }
            else if (month == "September")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * (72m * 0.90m));
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
                else if (nights > 7 && nights <= 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                }
            }
            else
            {
                if (nights > 14)
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * (89m * 0.85m));
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 89);
                }
            }
        }
    }
}