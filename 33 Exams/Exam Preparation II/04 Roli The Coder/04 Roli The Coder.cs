using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, SortedSet<string>>> solution =
                            new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (input != "Time for Code")
            {
                string[] tokens = input.Split();

                string iD = tokens[0];
                string eventName = tokens[1];

                if (eventName.First() != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!solution.ContainsKey(iD))
                {
                    solution.Add(iD, new Dictionary<string, SortedSet<string>>());
                    solution[iD].Add(eventName, new SortedSet<string>());
                    for (int cycle1 = 2; cycle1 < tokens.Length; cycle1++)
                    {
                        solution[iD][eventName].Add(tokens[cycle1]);
                    }
                }
                else
                {
                    if (!solution[iD].ContainsKey(eventName))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        for (int cycle1 = 2; cycle1 < tokens.Length; cycle1++)
                        {
                            solution[iD][eventName].Add(tokens[cycle1]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var iDevent in solution)
            {
                foreach (var eventParticipants in iDevent.Value.OrderBy(x => x.Value.Count))
                {
                    int kur = eventParticipants.Value.Count;
                    string withoutHash = eventParticipants.Key.Substring(1, eventParticipants.Key.Length - 1);
                    Console.WriteLine($"{withoutHash} - {eventParticipants.Value.Count}");
                    Console.WriteLine(string.Join("\n", eventParticipants.Value));
                }
            }

            //the foreach is not working properly, idk why
        }
    }
}