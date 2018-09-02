using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMSTyping
{
    class EmulateSMSTyping
    {
        static void Main(string[] args)
        {
            int numberOfCharakters = int.Parse(Console.ReadLine());
            string[] letters = { " ", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < numberOfCharakters; i++)
            {
                string input = Console.ReadLine();
                int number = input != "0" ? input[0] - '1' : input[0] - '0';
                int index = input.Length - 1;
                string letterSet = letters[number];
                message.Append(letterSet[index]);
            }
            Console.WriteLine(message);
        }
    }
}
