using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycle = int.Parse(Console.ReadLine());
            string ingredient = string.Empty;
            int calories = 0;

            for (int i = 0; i < cycle; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": calories += 500; break;
                    case "tomato sauce": calories += 150; break;
                    case "salami": calories += 600; break;
                    case "pepper": calories += 50; break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}