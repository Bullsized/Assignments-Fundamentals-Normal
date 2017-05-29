using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoAttack = int.Parse(Console.ReadLine());
            int goshoAttack = int.Parse(Console.ReadLine());

            int counter = 0;

            int peshoHealth = 100;
            int goshoHealth = 100;

            for (int cycle = 1; cycle < int.MaxValue; cycle++)
            {
                if (cycle % 2 != 0)
                {
                    counter++;
                    goshoHealth -= peshoAttack;
                    if (goshoHealth<= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", counter);
                        break;
                    }
                    else
                    {
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                    }
                }
                else if (cycle %2 == 0)
                {
                    counter++;
                    peshoHealth -= goshoAttack;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", counter);
                        break;
                    }
                    else
                    {
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    }
                }

                if (cycle %3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

            }
        }
    }
}