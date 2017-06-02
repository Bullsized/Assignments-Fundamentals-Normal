using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstMaterial = long.Parse(Console.ReadLine());
            long secondMaterial = long.Parse(Console.ReadLine());

            if (sbyte.MinValue <= firstMaterial && firstMaterial <= sbyte.MaxValue)
            {
                Console.WriteLine((4 * firstMaterial) + (10 * secondMaterial));
            }
            else
            {
                Console.WriteLine((4 * secondMaterial) + (10 * firstMaterial));
            }
        }
    }
}