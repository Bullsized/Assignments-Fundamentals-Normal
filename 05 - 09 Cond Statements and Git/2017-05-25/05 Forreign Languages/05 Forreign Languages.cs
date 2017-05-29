using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Forreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            //English is spoken in England and USA; Spanish is 
            //spoken in Spain, Argentina 
            //and Mexico; for the others, we should print "unknown".
            string language = Console.ReadLine();

            if (language == "England" || language =="USA")
            {
                Console.WriteLine("English");
            }
            else if (language == "Spain" || language == "Argentina" || language == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}