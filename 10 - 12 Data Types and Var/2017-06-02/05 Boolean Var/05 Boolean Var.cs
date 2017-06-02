using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Boolean_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool answer = Convert.ToBoolean(input);

            Console.WriteLine(answer ? "Yes" : "No"); 
        }
    }
}