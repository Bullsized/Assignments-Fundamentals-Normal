using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boatOneChar = char.Parse(Console.ReadLine());
            char boatTwoChar = char.Parse(Console.ReadLine());
            int rotation = int.Parse(Console.ReadLine());
            int progressOne = 0;
            int progressTwo = 0;
            bool lamp = false;

            for (int cycle = 1; cycle <= rotation; cycle++)
            {
                string command = Console.ReadLine();

                if (command == "UPGRADE")
                {
                    boatOneChar += (char)3;
                    boatTwoChar += (char)3;
                }

                if (cycle % 2 == 0)
                {
                    progressTwo += command.Length;
                }
                else
                {
                    progressOne += command.Length;
                }

                if (progressOne >= 50)
                {
                    Console.WriteLine(boatOneChar);
                    lamp = true;
                    break;
                }
                else if (progressTwo >= 50)
                {
                    Console.WriteLine(boatTwoChar);
                    lamp = true;
                    break;
                }
            }
            if (progressOne > progressTwo && lamp == false)
            {
                Console.WriteLine(boatOneChar);
            }
            else if (progressOne < progressTwo && lamp == false)
            {
                Console.WriteLine(boatTwoChar);
            }
        }
    }
}