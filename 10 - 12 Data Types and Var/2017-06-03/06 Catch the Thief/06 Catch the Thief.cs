using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            // “sbyte”, “int” or “long”. 
            string typeOfData = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long parsing = 0;
            long storedParse = long.MinValue;

            for (int cycle = 0; cycle < n; cycle++)
            {
                parsing = long.Parse(Console.ReadLine());


                if (typeOfData == "sbyte")
                {
                    if (sbyte.MinValue <= parsing && parsing <= sbyte.MaxValue)
                    {
                        if (parsing > storedParse)
                        {
                            storedParse = parsing;
                        }
                    }
                }
                else if (typeOfData == "int")
                {
                    if (int.MinValue <= parsing && parsing <= int.MaxValue)
                    {
                        if (parsing > storedParse)
                        {
                            storedParse = parsing;
                        }
                    }
                }
                else if (typeOfData == "long")
                {
                    if (long.MinValue <= parsing && parsing <= long.MaxValue)
                    {
                        if (parsing > storedParse)
                        {
                            storedParse = parsing;
                        }
                    }
                }
            }

            Console.WriteLine(storedParse);
        }
    }
}