using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Triples_of_Latin_L
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char letter = (char)('^' + n);

            for (char first = letter; first < letter + 3; first++)
            {
                for (char second = letter; second < letter + 3; second++)
                {
                    for (char third = letter; third < letter + 3; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}