using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLines = File.ReadAllLines("input01.txt");
            string[] secondLines = File.ReadAllLines("input02.txt");

            string[] output = new string[firstLines.Length + secondLines.Length];

            for (int cycle = 0; cycle < firstLines.Length; cycle++)
            {
                    output[cycle] = firstLines[cycle] + Environment.NewLine + secondLines[cycle];               
            }

            File.WriteAllLines("merged.txt", output);
        }
    }
}