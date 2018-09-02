using System;
using System.Collections.Generic;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneData =
                new Dictionary<string, string>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="END")
            {
                string[] inputTokens = input.Split();
                string action = inputTokens[0];
                string name = inputTokens[1];
               
                if (action=="A")
                {
                    string phoneNumber = inputTokens[2];
                    if (!phoneData.ContainsKey(name))
                    {
                        phoneData.Add(name, phoneNumber);
                    }
                    phoneData[name] = phoneNumber;
                }
                else if (action=="S")
                {
                    if (phoneData.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneData[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
