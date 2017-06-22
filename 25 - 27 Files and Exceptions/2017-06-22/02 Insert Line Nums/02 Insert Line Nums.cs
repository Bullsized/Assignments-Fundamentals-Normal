using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insert_Line_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("everybody wants some.txt");
            var numberedLines = lines.Select((line, index) => (index + 1) + ". " + line);
            File.WriteAllLines("everybody lined.txt", numberedLines);
        }
    }
}