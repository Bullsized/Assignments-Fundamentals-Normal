using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());

            string virus = Console.ReadLine();

            List<string> virusesFought = new List<string>();

            int workingHealth = initialHealth;

            bool lamp = false;

            while (virus != "end")
            {
                lamp = false;

                if (virusesFought.Contains(virus))
                {
                    int counter = 0;

                    for (int cycle3 = 0; cycle3 < virusesFought.Count; cycle3++)
                    {
                        if (virusesFought[cycle3] == virus)
                        {
                            counter++;
                        }
                    }

                    if (counter == 1)
                    {
                        char[] splitVirusWithLessTimeToKill = virus.ToCharArray();

                        decimal totalVirusStrenghtLess = 0;

                        for (int cycle = 0; cycle < splitVirusWithLessTimeToKill.Length; cycle++)
                        {
                            totalVirusStrenghtLess += splitVirusWithLessTimeToKill[cycle];
                        }

                        int timeToDefeatTheVirusLess = (int)Math.Truncate(totalVirusStrenghtLess / 3);

                        int totalTimeInSecondsLess = timeToDefeatTheVirusLess * splitVirusWithLessTimeToKill.Length / 3;

                        int timeMinutesLess = totalTimeInSecondsLess / 60;

                        int timeSecondsLess = totalTimeInSecondsLess % 60;

                        workingHealth -= totalTimeInSecondsLess;
                        if (workingHealth > 0)
                        {
                            Console.WriteLine($"Virus {virus}: {timeToDefeatTheVirusLess} => {totalTimeInSecondsLess} seconds");
                            Console.WriteLine($"{virus} defeated in {timeMinutesLess}m {timeSecondsLess}s.");
                            Console.WriteLine("Remaining health: {0}", workingHealth);

                            workingHealth = (int)Math.Truncate(workingHealth * 1.2);

                            if (workingHealth > initialHealth)
                            {
                                workingHealth = initialHealth;
                            }

                            lamp = true;
                        }
                        else
                        {
                            Console.WriteLine($"Virus {virus}: {timeToDefeatTheVirusLess} => {totalTimeInSecondsLess} seconds");
                            Console.WriteLine("Immune System Defeated.");
                            break;
                        }
                    }

                }
                else
                {
                    char[] splitVirus = virus.ToCharArray();

                    decimal totalVirusStrenght = 0;

                    for (int cycle = 0; cycle < splitVirus.Length; cycle++)
                    {
                        totalVirusStrenght += splitVirus[cycle];
                    }

                    int timeToDefeatTheVirus = (int)Math.Truncate(totalVirusStrenght / 3);

                    int totalTimeInSeconds = timeToDefeatTheVirus * splitVirus.Length;

                    int timeMinutes = totalTimeInSeconds / 60;

                    int timeSeconds = totalTimeInSeconds % 60;

                    workingHealth -= totalTimeInSeconds;

                    if (workingHealth > 0)
                    {
                        Console.WriteLine($"Virus {virus}: {timeToDefeatTheVirus} => {totalTimeInSeconds} seconds");
                        Console.WriteLine($"{virus} defeated in {timeMinutes}m {timeSeconds}s.");
                        Console.WriteLine("Remaining health: {0}", workingHealth);

                        workingHealth = (int)Math.Truncate(workingHealth * 1.2);

                        if (workingHealth > initialHealth)
                        {
                            workingHealth = initialHealth;
                        }

                        lamp = true;
                    }
                    else
                    {
                        Console.WriteLine($"Virus {virus}: {timeToDefeatTheVirus} => {totalTimeInSeconds} seconds");
                        Console.WriteLine("Immune System Defeated.");
                        break;
                    }

                }

                virusesFought.Add(virus);

                virus = Console.ReadLine();
            }

            if (lamp == true)
            {
                Console.WriteLine("Final Health: {0}", workingHealth);
            }
        }
    }
}