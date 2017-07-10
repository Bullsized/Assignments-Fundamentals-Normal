using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower01 = int.Parse(Console.ReadLine());
            int distanceBetween02 = int.Parse(Console.ReadLine());
            int exhaustFactor03 = int.Parse(Console.ReadLine());

            decimal inHalf04 = pokePower01 * 0.5m;

            int countPokes05 = 0;

            while (distanceBetween02 <= pokePower01)
            {
                pokePower01 -= distanceBetween02;
                countPokes05++;

                if (pokePower01 == inHalf04 && exhaustFactor03 > 0)
                {
                    pokePower01 /= exhaustFactor03;
                }
            }

            Console.WriteLine(pokePower01);
            Console.WriteLine(countPokes05);
        }
    }
}