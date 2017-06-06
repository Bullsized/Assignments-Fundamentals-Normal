using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //75 out of 100, playing with the Prime Method
            int primeOrNot = int.Parse(Console.ReadLine());

            bool lamp = false;

            lamp = IsPrime(primeOrNot, lamp);

            Console.WriteLine(lamp);
        }

        private static bool IsPrime(int primeOrNot, bool lamp)
        {
            if (primeOrNot == 1) return false;
            if (primeOrNot == 2) return true;

            if (primeOrNot % 2 == 0) return false;  

            for (int i = 2; i < primeOrNot; i++)
            { 
                if (primeOrNot % i == 0) return false;
            }

            return true;           
        }
    }
}