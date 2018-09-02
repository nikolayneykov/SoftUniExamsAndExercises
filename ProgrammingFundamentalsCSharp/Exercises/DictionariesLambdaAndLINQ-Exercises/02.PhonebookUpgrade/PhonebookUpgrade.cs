using System;
using System.Collections.Generic;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneData =
                  new SortedDictionary<string, string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputTokens = input.Split();
                string action = inputTokens[0];

                if (action == "A")
                {
                    string name = inputTokens[1];
                    string phoneNumber = inputTokens[2];
                    if (!phoneData.ContainsKey(name))
                    {
                        phoneData.Add(name, phoneNumber);
                    }
                    phoneData[name] = phoneNumber;
                }
                else if (action == "S")
                {
                    string name = inputTokens[1];
                    if (phoneData.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneData[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (action== "ListAll")
                {
                    foreach (KeyValuePair<string,string> phone in phoneData)
                    {
                        Console.WriteLine($"{phone.Key} -> {phone.Value}");
                    }
                }
            }

        }
    }
}
