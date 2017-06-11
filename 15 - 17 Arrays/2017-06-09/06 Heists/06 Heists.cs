using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int priceOfJewels = lineOfDigits[0];
            int priceOfGold = lineOfDigits[1];

            string[] lootAndExpenses = Console.ReadLine().Split();

            int totalEarnings = 0;
            int totalExpenses = 0;

            while (lootAndExpenses[0] != "Jail")
            {
                totalExpenses += int.Parse(lootAndExpenses[1]);

                char[] splittedLoot = lootAndExpenses[0].ToCharArray();

                for (int cycle1 = 0; cycle1 < splittedLoot.Length; cycle1++)
                {
                    if (splittedLoot[cycle1] == '%')
                    {
                        totalEarnings += priceOfJewels;
                    }
                    else if (splittedLoot[cycle1] == '$')
                    {
                        totalEarnings += priceOfGold;
                    }
                }

                lootAndExpenses = Console.ReadLine().Split();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }
        }
    }
}