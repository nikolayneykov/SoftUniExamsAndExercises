using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string symbols = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!symbols.Contains(currentChar))
                {
                    symbols += currentChar.ToString();
                }
            }
            for (int i = 0; i < symbols.Length; i++)
            {
                char currentChar = symbols[i];
                int index = input.IndexOf(currentChar);
                Console.Write(currentChar + ":" + index);
                index = input.IndexOf(currentChar, index + 1);
                while (index != -1)
                {
                    Console.Write("/" + index);
                    index = input.IndexOf(currentChar, index + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
