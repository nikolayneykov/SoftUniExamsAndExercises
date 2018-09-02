using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniExamResults
{
    class SoftUniExamResults
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = input.Split('-');
                if (tokens[1] == "banned")
                {
                    results.Remove(tokens[0]);
                    continue;
                }

                string username = tokens[0];
                int points = int.Parse(tokens[2]);
                if (!results.ContainsKey(username))
                {
                    results.Add(username, points);
                }
                else if (results[username] < points)
                {
                    results[username] = points;
                }

                string language = tokens[1];
                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 0);
                }
                submissions[language]++;
            }

            Console.WriteLine("Results:");
            foreach (var user in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var submission in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
