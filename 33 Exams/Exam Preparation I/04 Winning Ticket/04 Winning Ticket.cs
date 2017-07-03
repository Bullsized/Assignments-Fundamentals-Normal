using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int cycle = 0; cycle < tickets.Length; cycle++)
            {
                string currentTicket = tickets[cycle];

                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string firstTen = new string(currentTicket.Take(10).ToArray()); //currentTicket.Substring(0, 10);
                    string secondTen = new string(currentTicket.Skip(10).Take(10).ToArray());

                    int jackpot = string.Compare(firstTen, secondTen);

                    if (jackpot == 0)
                    {
                        Console.WriteLine("ticket \"" + currentTicket + "\" - 10{0} Jackpot!", firstTen.First());
                    }
                    else
                    {
                        char[] firstHalfToChar = firstTen.ToCharArray();
                        char[] secondHalfToChar = secondTen.ToCharArray();

                        int currentCount = 1;
                        int maxCount = 0;
                        char winningSymbol = ' ';

                        for (int cycle2 = 1; cycle2 < firstHalfToChar.Length; cycle2++)
                        {
                            if (firstHalfToChar[cycle2 - 1] == firstHalfToChar[cycle2])
                            {
                                currentCount++;
                            }
                            else
                            {
                                currentCount = 1;
                            }

                            if (currentCount > maxCount)
                            {
                                maxCount = currentCount;
                                winningSymbol = firstHalfToChar[cycle2 - 1];
                            }
                        }

                        int nextCount = 1;
                        int maxNextCount = 0;
                        char winningSymbolTwo = ' ';

                        for (int cycle3 = 1; cycle3 < secondHalfToChar.Length; cycle3++)
                        {
                            if (secondHalfToChar[cycle3 - 1] == secondHalfToChar[cycle3])
                            {
                                nextCount++;
                            }
                            else
                            {
                                nextCount = 1;
                            }

                            if (nextCount > maxNextCount)
                            {
                                maxNextCount = nextCount;
                                winningSymbolTwo = secondHalfToChar[cycle3 - 1];
                            }
                        }

                        if (maxCount >= 6 && maxNextCount >= 6 && winningSymbol == winningSymbolTwo)
                        {
                            Console.WriteLine("ticket \"" + currentTicket + "\" - {0}{1}", Math.Min(maxNextCount, maxCount), winningSymbol);
                        }
                        else
                        {
                            Console.WriteLine("ticket \"" + currentTicket + "\" - no match");
                        }
                    }
                }
            }

           
            //RegEx solution:
            //string[] inputTickets = Console.ReadLine()
            //    .Split(',')
            //    .Select(x => x.Trim())
            //    .ToArray();

            //string ticketPattern = @"@{6,9}|#{6,9}|\${6,9}|\^{6,9}";
            //Regex winningTicket = new Regex(ticketPattern);
            //string jackpotPattern = @"@{10}|#{10}|\${10}|\^{10}";
            //Regex winJackpot = new Regex(jackpotPattern);


            //for (int i = 0; i < inputTickets.Length; i++)
            //{
            //    string currentTicket = inputTickets[i];
            //    bool isValidTicket = true;
            //    if (currentTicket.Length != 20)
            //    {
            //        isValidTicket = false;
            //    }

            //    if (isValidTicket)
            //    {
            //        string leftPart = currentTicket.Substring(0, 10);
            //        string rightPart = currentTicket.Substring(10, 10);

            //        var matchedLeftPartForJackpot = winJackpot.Match(leftPart);
            //        var matchedRightPartForJackpot = winJackpot.Match(rightPart);

            //        var matchedWinningTicketLeftPart = winningTicket.Match(leftPart);
            //        var matchedWinningTicketRightPart = winningTicket.Match(rightPart);

            //        if (matchedLeftPartForJackpot.Success
            //            && matchedRightPartForJackpot.Success
            //            && leftPart == rightPart)
            //        {
            //            char winningSymbol = leftPart[0];
            //            Console.WriteLine($"ticket \"{currentTicket}\" - 10{winningSymbol} Jackpot!");
            //        }
            //        else if (matchedWinningTicketLeftPart.Success
            //            && matchedWinningTicketRightPart.Success
            //            && leftPart[5] == rightPart[5])
            //        {
            //            char winningSymbol = leftPart[5];
            //            int minimumMachedWinSymbols = Math.Min(matchedWinningTicketRightPart.Value.Count(), matchedWinningTicketLeftPart.Value.Count());
            //            Console.WriteLine($"ticket \"{currentTicket}\" - {minimumMachedWinSymbols}{winningSymbol}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"ticket \"{currentTicket}\" - no match");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid ticket");
            //    }
            //}
        }
    }
}