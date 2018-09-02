using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DeserializeString
{
    class DeserializeString
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<char, List<int>> tokensData =
                new Dictionary<char, List<int>>();

            while ((input = Console.ReadLine()) != "end")
            {
                char symbol = input[0];
                tokensData.Add(symbol, new List<int>(input
                    .Split(':', '/').Skip(1).Select(int.Parse).ToList()));
            }
            int arrLength = tokensData.Values.Max(x => x.Max());
            char[] result = new char[arrLength + 1];
            foreach (KeyValuePair<char, List<int>> symbol in tokensData)
            {
                char currentChar = symbol.Key;
                for (int i = 0; i < symbol.Value.Count; i++)
                {
                    int index = symbol.Value[i];
                    result[index] = currentChar;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
