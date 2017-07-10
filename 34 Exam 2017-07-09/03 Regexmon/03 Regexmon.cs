using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex didimon01 = new Regex(@"([^A-Za-z\-]+)");
            Regex bojomon02 = new Regex(@"([A-Za-z]+-[A-Za-z]+)");

            string inputLine = Console.ReadLine();

            bool lamp = false;

            int counter = 0;
            
            while (lamp != true)
            {
                if (counter % 2 == 0)
                {
                    Match match = didimon01.Match(inputLine);
                    if (match.Success)
                    {
                        string valueAndStart = match.Value.ToString();
                        Console.WriteLine(match.Value.ToString());
                        int remove = inputLine.IndexOf(valueAndStart);
                        inputLine = inputLine.Remove(0, valueAndStart.Length + remove);
                    }
                    else
                    {
                        lamp = true;
                    }
                    counter++;
                }
                else if (counter % 2 != 0)
                {
                    Match match = bojomon02.Match(inputLine);
                    if (match.Success)
                    {
                        string valueAndStart = match.Value.ToString();
                        Console.WriteLine(match.Value.ToString());
                        int remove = inputLine.IndexOf(valueAndStart);
                        inputLine = inputLine.Remove(0, valueAndStart.Length + remove);
                    }
                    else
                    {
                        lamp = true;
                    }
                    counter++;
                }
            }

        }
    }
}