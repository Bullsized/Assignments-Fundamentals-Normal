using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age <= 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (typeOfDay == "Weekday")
                {
                    if (age <= 18)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age <= 64)
                    {
                        Console.WriteLine("18$");
                    }
                    else
                    {
                        Console.WriteLine("12$");
                    }
                }
                else if (typeOfDay == "Weekend")
                {
                    if (age <= 18)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (age <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else
                    {
                        Console.WriteLine("15$");
                    }
                }
                else if (typeOfDay == "Holiday")
                {
                    if (age <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("10$");
                    }
                }
            }
        }
    }
}