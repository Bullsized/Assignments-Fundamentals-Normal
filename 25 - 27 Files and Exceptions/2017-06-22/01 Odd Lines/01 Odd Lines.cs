using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Odd_Lines
{
    class Program
    {
        static void Main(string[] args) //practicing files, nevermind the file ~
        {
            string[] lines = File.ReadAllLines("everybody wants some.txt");
            var oddLines = lines.Where((line, index) => index % 2 != 0);
            File.WriteAllLines("odd lines ews.txt", oddLines);
        }

        static void NewWayToDoIt()
        {
            string[] lines = File.ReadAllLines("everybody wants some.txt");
            File.Delete("odd lines ews.txt");
            for (int cycle = 1; cycle < lines.Length; cycle+=2)
            {
                File.AppendAllText("new odd lines ews.txt", lines[cycle] + Environment.NewLine);
            }
        }
    }
}
