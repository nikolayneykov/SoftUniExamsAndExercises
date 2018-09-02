using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            Regex regMessage = new Regex(@"^([0-9]+) <-> ([a-zA-Z0-9]+)$");
            Regex regBroadcast = new Regex(@"^([^0-9]+) <-> ([a-zA-Z0-9]+)$");

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                if (regMessage.IsMatch(input))
                {
                    string code = new string(regMessage
                        .Match(input)
                        .Groups[1]
                        .Value
                        .ToCharArray()
                        .Reverse()
                        .ToArray());
                    string message = regMessage
                        .Match(input)
                        .Groups[2]
                        .Value;

                    messages.Add($"{code} -> {message}");
                }
                else if (regBroadcast.IsMatch(input))
                {
                    string message = regBroadcast
                        .Match(input)
                        .Groups[1]
                        .Value;
                    string frequency = regBroadcast
                        .Match(input)
                        .Groups[2]
                        .Value;
                    StringBuilder refactoredFrequency = new StringBuilder();
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLetter(frequency[i]))
                        {
                            refactoredFrequency.Append(
                                char.IsLower(frequency[i]) ?
                                char.ToUpper(frequency[i]) :
                                char.ToLower(frequency[i]));
                        }
                        else
                        {
                            refactoredFrequency.Append(frequency[i]);
                        }
                    }
                    broadcasts.Add($"{refactoredFrequency} -> {message}");
                }
            }
            Console.WriteLine(broadcasts.Count>0?"Broadcasts:":"Broadcasts:\nNone");
            foreach (string broadcast in broadcasts)
            {
                Console.WriteLine(broadcast);
            }
            Console.WriteLine(messages.Count > 0 ? "Messages:" : "Messages:\nNone");
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
