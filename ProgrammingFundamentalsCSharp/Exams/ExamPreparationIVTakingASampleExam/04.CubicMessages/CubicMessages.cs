using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Over!")
            {
                int messageLength = int.Parse(Console.ReadLine());
                string messagePattern = $@"^(\d+)([a-zA-Z]{{{messageLength}}})([^a-zA-Z]*)$";
                Regex rgx = new Regex(messagePattern);
                if (rgx.IsMatch(input))
                {
                    string message = rgx.Match(input).Groups[2].Value;
                    string indexes = rgx.Match(input).Groups[1].Value +
                        rgx.Match(input).Groups[3].Value;
                    StringBuilder verificationCode = new StringBuilder();
                    for (int i = 0; i < indexes.Length; i++)
                    {
                        if (char.IsDigit(indexes[i]))
                        {
                            int index = int.Parse(indexes[i].ToString());
                            if (index >= 0 && index < message.Length)
                            {
                                verificationCode.Append(message[index]);
                            }
                            else
                            {
                                verificationCode.Append(" ");
                            }
                        }
                    }
                    Console.WriteLine($"{message} == {verificationCode}");
                }
            }
        }
    }
}
