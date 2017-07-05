using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex dragonDmg = new Regex(@"-?[0-9]\.?[0-9]*");

            string[] dragons = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<decimal>> output = new Dictionary<string, List<decimal>>();

            foreach (var dragon in dragons)
            {
                output.Add(dragon, new List<decimal>());

                char[] dealWithTheDragon = dragon.ToCharArray();

                decimal health = 0;

                decimal damage = 0;

                MatchCollection totalDmg = dragonDmg.Matches(dragon);

                foreach (Match dmg in totalDmg)
                {
                    damage += decimal.Parse(dmg.Value);
                }

                for (int cycleHealth = 0; cycleHealth < dealWithTheDragon.Length; cycleHealth++)
                {
                    if (65 <= dealWithTheDragon[cycleHealth] && dealWithTheDragon[cycleHealth] <= 90 ||
                        97 <= dealWithTheDragon[cycleHealth] && dealWithTheDragon[cycleHealth] <= 122)
                    {
                        health += dealWithTheDragon[cycleHealth];
                    }
                    else if (dealWithTheDragon[cycleHealth] == '*')
                    {
                        damage *= 2;
                    }
                    else if (dealWithTheDragon[cycleHealth] == '/')
                    {
                        damage /= 2;
                    }
                }

                output[dragon].Add(health);
                output[dragon].Add(damage);
            }

            foreach (var dragon in output.OrderBy(dragon => dragon.Key))
            {
                Console.WriteLine($"{dragon.Key} - {dragon.Value[0]} health, {dragon.Value[1]:f2} damage");
            }
        }
    }
}