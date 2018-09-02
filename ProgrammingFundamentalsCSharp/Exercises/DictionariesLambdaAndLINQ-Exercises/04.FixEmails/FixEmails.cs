using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails =
                            new Dictionary<string, string>();
            string name = string.Empty;
            string email = string.Empty;
            while ((name = Console.ReadLine()) != "stop" &&
                   (email = Console.ReadLine()) != "stop")
            {
                if (!emails.ContainsKey(name) && 
                    !email.ToLower().EndsWith("us")&& 
                    !email.ToLower().EndsWith("uk"))
                {
                    emails.Add(name, email);
                }
            }
            foreach (KeyValuePair<string, string> item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
