using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int decrypt = int.Parse(Console.ReadLine());
            int rotation = int.Parse(Console.ReadLine());
            string answer = string.Empty;

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                char input = char.Parse(Console.ReadLine());
                answer += (char)(input + decrypt);
            }
            Console.WriteLine(answer);
        }
    }
}