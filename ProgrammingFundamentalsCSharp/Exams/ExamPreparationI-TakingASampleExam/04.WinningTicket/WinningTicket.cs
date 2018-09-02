using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string ticket in input)
            {

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Regex pattern = new Regex(@".*?(?<valid>@{6,10}|#{6,10}|\${6,10}|\^{6,10}).*?");
                    string leftPart = ticket.Substring(0, 10);
                    string rightPart = ticket.Substring(10, 10);

                    if (pattern.IsMatch(leftPart) && pattern.IsMatch(rightPart))
                    {
                        leftPart = pattern.Match(leftPart).Groups["valid"].Value;
                        rightPart = pattern.Match(rightPart).Groups["valid"].Value;
                        if (leftPart[0] == rightPart[0])
                        {
                            string validMatch = leftPart.Length < rightPart.Length ? leftPart : rightPart;
                            if (validMatch.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {validMatch.Length}{validMatch[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {validMatch.Length}{validMatch[0]}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
