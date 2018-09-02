using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {

            string key = Regex.Escape(Console.ReadLine());
            Regex rgx = new Regex(
               $@"{key}(?<t1>.*?){key}.+?{key}(?<t2>.*?){key}.+?(?<t1Goals>\d+):(?<t2Goals>\d+)");

            Dictionary<string, int> goals =
                   new Dictionary<string, int>();
            Dictionary<string, int> points =
                new Dictionary<string, int>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "final")
            {
                string team1 = new string(rgx.Match(input)
                    .Groups["t1"]
                    .Value.ToCharArray()
                    .Reverse()
                    .ToArray())
                    .ToUpper();
                int team1Goals = int.Parse(rgx.Match(input)
                    .Groups["t1Goals"]
                    .Value);
                string team2 = new string(rgx.Match(input)
                    .Groups["t2"]
                    .Value.ToCharArray()
                    .Reverse()
                    .ToArray())
                    .ToUpper();
                int team2Goals = int.Parse(rgx.Match(input)
                    .Groups["t2Goals"]
                    .Value);
                if (!points.ContainsKey(team1))
                {
                    points.Add(team1, 0);
                }
                if (!points.ContainsKey(team2))
                {
                    points.Add(team2, 0);
                }
                if (team1Goals == team2Goals)
                {
                    points[team1]++;
                    points[team2]++;
                }
                else if (team1Goals > team2Goals)
                {
                    points[team1] += 3;
                }
                else if (team2Goals > team1Goals)
                {
                    points[team2] += 3;
                }

                if (!goals.ContainsKey(team1))
                {
                    goals.Add(team1, 0);
                }
                if (!goals.ContainsKey(team2))
                {
                    goals.Add(team2, 0);
                }
                goals[team1] += team1Goals;
                goals[team2] += team2Goals;
            }
            points = points
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            int placeCount = 1;
            Console.WriteLine("League standings:");
            foreach (KeyValuePair<string, int> teamPoints in points)
            {
                string team = teamPoints.Key;
                int score = teamPoints.Value;
                Console.WriteLine($"{placeCount}. {team} {score}");
                placeCount++;
            }
            Console.WriteLine("Top 3 scored goals:");
            goals = goals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, int> teamGoals in goals)
            {
                string team = teamGoals.Key;
                int goal = teamGoals.Value;
                Console.WriteLine($"- {team} -> {goal}");
            }
        }
    }
}
