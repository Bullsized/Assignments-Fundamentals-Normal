using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] one = Console.ReadLine().ToCharArray();
            char[] two = Console.ReadLine().ToCharArray();
            List<int> newList = new List<int>();
            int residue = 0;
            int goDown = 0;

            if (one.Length <= two.Length)
            {
                for (int iii = one.Length - 1; iii >= 0; iii--)
                {
                    int oneCurrent = int.Parse(one[iii].ToString());
                    int twoCurrent = int.Parse(two[two.Length - 1 - goDown].ToString());
                    if (residue + oneCurrent + twoCurrent < 10)
                    {
                        newList.Insert(0, residue + oneCurrent + twoCurrent);
                        residue = 0;
                    }
                    else
                    {
                        int divByPercTen = (residue + oneCurrent + twoCurrent) % 10;
                        newList.Insert(0, divByPercTen);
                        residue = 1;
                    }
                    goDown++;
                }

                for (int uuu = two.Length - one.Length - 1; uuu >= 0; uuu--)
                {
                    int currentToIns = int.Parse(two[uuu].ToString());
                    if (currentToIns + residue < 10)
                    {
                        newList.Insert(0, currentToIns + residue);
                        residue = 0;
                    }
                    else
                    {
                        int divByPercTen = (residue + currentToIns) % 10;
                        newList.Insert(0, divByPercTen);
                        residue = 1;
                    }
                }

                if (residue == 1)
                {
                    newList.Insert(0, 1);
                }

            }
            else
            {
                for (int iii = two.Length - 1; iii >= 0; iii--)
                {
                    int twooCurrent = int.Parse(two[iii].ToString());
                    int oneeCurrent = int.Parse(one[two.Length - 1 - goDown].ToString());
                    if (residue + twooCurrent + oneeCurrent < 10)
                    {
                        newList.Insert(0, residue + twooCurrent + oneeCurrent);
                        residue = 0;
                    }
                    else
                    {
                        int divByPercTen = (residue + twooCurrent + oneeCurrent) % 10;
                        newList.Insert(0, divByPercTen);
                        residue = 1;
                    }
                    goDown++;
                }

                for (int uuu = one.Length - two.Length - 1; uuu >= 0; uuu--)
                {
                    int currentToIns = int.Parse(one[uuu].ToString());
                    if (currentToIns + residue < 10)
                    {
                        newList.Insert(0, currentToIns + residue);
                        residue = 0;
                    }
                    else
                    {
                        int divByPercTen = (residue + currentToIns) % 10;
                        newList.Insert(0, divByPercTen);
                        residue = 1;
                    }
                }

                if (residue == 1)
                {
                    newList.Insert(0, 1);
                }
            }

            Console.WriteLine(string.Join("", newList));

        }
    }
}