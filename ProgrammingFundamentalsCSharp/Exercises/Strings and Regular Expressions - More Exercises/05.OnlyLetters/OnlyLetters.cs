using System;

namespace _05.OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    int index = i;
                    string replacement = "";
                    string number = "";
                    while (index < message.Length && char.IsDigit(message[index]))
                    {
                        number += message[index];
                        index++;
                        if (index < message.Length && char.IsLetter(message[index]))
                        {
                            replacement = message[index].ToString();
                        }
                    }
                    if (replacement != "")
                    {
                        message = message.Replace(number, replacement);
                    }
                }
            }
            Console.WriteLine(string.Join("", message));
        }
    }
}
