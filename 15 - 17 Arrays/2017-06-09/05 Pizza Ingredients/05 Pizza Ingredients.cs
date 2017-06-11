using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            int specificLength = int.Parse(Console.ReadLine());

            string[] nameOfIngredients = new string[10];

            int nextIngredient = 0;

            int countOfIngredients = 0;

            for (int cycle1 = 0; cycle1 < ingredients.Length; cycle1++)
            {
                if (ingredients[cycle1].Length == specificLength)
                {
                    countOfIngredients++;
                    Console.WriteLine($"Adding {ingredients[cycle1]}.");
                    nameOfIngredients[nextIngredient] = ingredients[cycle1];
                    nextIngredient++;
                }

                if (countOfIngredients == 10)
                {
                    break;
                }
            }

            PrintThePizzas(nameOfIngredients, countOfIngredients);

        }

        private static void PrintThePizzas(string[] nameOfIngredients, int countOfIngredients)
        {
            Array.Resize(ref nameOfIngredients, countOfIngredients);
            Console.WriteLine($"Made pizza with total of {countOfIngredients} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", nameOfIngredients)}.");
        }
    }
}