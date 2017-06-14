using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userIPtimes = new Dictionary<string, Dictionary<string, int>>();

            string[] inputLines = Console.ReadLine().Split(' ', '=');

            while (inputLines[0] != "end")
            {
                string username = inputLines[5];
                string IPv4v6 = inputLines[1];

                if (!userIPtimes.ContainsKey(username))
                {
                    userIPtimes[username] = new Dictionary<string, int>();
                    userIPtimes[username].Add(IPv4v6, 1);
                }
                else
                {
                    if (userIPtimes[username].ContainsKey(IPv4v6))
                    {
                        userIPtimes[username][IPv4v6]++;
                    }
                    else
                    {
                        userIPtimes[username].Add(IPv4v6, 1);
                    }
                }

                inputLines = Console.ReadLine().Split(' ', '=');

            }

            var orderedUserIPtimes = userIPtimes.OrderBy(x => x.Key).ToList();
            
            foreach (var kvp in orderedUserIPtimes)
            {
                Console.WriteLine(kvp.Key + ":");
                int counter = 1;
                foreach (var ipAndTimes in kvp.Value)
                {
                    if (kvp.Value.Count == counter)
                    {
                        Console.WriteLine($"{ipAndTimes.Key} => {ipAndTimes.Value}.");
                        break;
                    }
                    Console.Write($"{ipAndTimes.Key} => {ipAndTimes.Value}, ");
                    counter++;
                }
            }
        }
    }
}