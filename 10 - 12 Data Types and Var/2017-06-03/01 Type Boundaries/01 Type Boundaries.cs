using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int": Console.WriteLine(int.MaxValue + Environment.NewLine + int.MinValue); break;
                case "uint": Console.WriteLine(uint.MaxValue + Environment.NewLine + uint.MinValue); break;
                case "long": Console.WriteLine(long.MaxValue + Environment.NewLine + long.MinValue); break;
                case "byte": Console.WriteLine(byte.MaxValue + Environment.NewLine + byte.MinValue); break;
                case "sbyte": Console.WriteLine(sbyte.MaxValue + Environment.NewLine + sbyte.MinValue); break;
            }
        }
    }
}
