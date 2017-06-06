using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            OutputName(name);
        }

        static void OutputName (string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
}