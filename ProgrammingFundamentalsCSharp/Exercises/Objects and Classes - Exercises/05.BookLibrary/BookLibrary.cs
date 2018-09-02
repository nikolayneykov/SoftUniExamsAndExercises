using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();
                string author = inputTokens[1];
                decimal price = decimal.Parse(inputTokens[5]);
                if (!authors.ContainsKey(author))
                {
                    authors.Add(author, 0);
                }
                authors[author] += price;
            }

            foreach (var author in authors.OrderByDescending(a=>a.Value).ThenBy(a=>a.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }
}