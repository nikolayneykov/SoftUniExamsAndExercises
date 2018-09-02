using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SpyGram
{
    class SpyGram
    {
        static void Main(string[] args)
        {
            int[] privateKey = Console.ReadLine()
                .ToCharArray()
                .Select(x => x - '0')
                .ToArray();
            string input;
            Dictionary<string, List<string>> data =
                 new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "END")
            {
                Regex validMessage = new Regex("^TO: (?<recipient>[A-Z]+); MESSAGE: (?<message>.*?);$");
                if (validMessage.IsMatch(input))
                {
                    string recipient = validMessage.Match(input).Groups["recipient"].Value;
                    if (!data.ContainsKey(recipient))
                    {
                        data.Add(recipient, new List<string>());
                    }
                    data[recipient].Add(input);
                }
            }
            data = data
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, List<string>> sender in data)
            {
                List<string> currentMessages = sender.Value;
                foreach (string message in currentMessages)
                {
                    StringBuilder encryptendMessage = new StringBuilder();
                    for (int i = 0, j = 0; i < message.Length; i++, j++)
                    {
                        encryptendMessage.Append((char)(message[i] + privateKey[j]));
                        if (j == privateKey.Length - 1)
                        {
                            j = -1;
                        }
                    }
                    Console.WriteLine(encryptendMessage);
                }
            }
        }
    }
}
