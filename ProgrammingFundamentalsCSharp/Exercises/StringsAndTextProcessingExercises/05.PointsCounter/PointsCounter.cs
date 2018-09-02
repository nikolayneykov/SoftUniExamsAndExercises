using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PointsCounter
{
    class PointsCounter
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> teamData =
                new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "Result")
            {
                string[] inputTokens = input.Split('|');
                string teamName;
                string playerName;
                if (IsTeamName(inputTokens[0]))
                {
                    teamName = inputTokens[0];
                    playerName = inputTokens[1];
                }
                else
                {
                    teamName = inputTokens[1];
                    playerName = inputTokens[0];
                }
                teamName = RemoveSymbols(teamName);
                playerName = RemoveSymbols(playerName);
                int playerScore = int.Parse(inputTokens[2]);

                if (!teamData.ContainsKey(teamName))
                {
                    teamData.Add(teamName, new Dictionary<string, int>());
                }
                if (!teamData[teamName].ContainsKey(playerName))
                {
                    teamData[teamName].Add(playerName, playerScore);
                }
                teamData[teamName][playerName] = playerScore;
            }
            teamData = teamData
                .OrderByDescending(t => t.Value.Values.Sum())
                .ToDictionary(t => t.Key, t => t.Value.
                   OrderByDescending(p => p.Value).
                   ToDictionary(p => p.Key, p => p.Value));


            foreach (KeyValuePair<string, Dictionary<string, int>> team in teamData)
            {
                string teamName = team.Key;
                int totalScore = team.Value.Values.Sum();
                string topPlayer = team.Value.Keys.First();
                Console.WriteLine($"{team.Key} => {totalScore}");
                Console.WriteLine($"Most points scored by {topPlayer}");
            }
        }
        static string RemoveSymbols(string str)
        {
            str = str.Replace("@", "");
            str = str.Replace("%", "");
            str = str.Replace("$", "");
            str = str.Replace("*", "");
            return str;
        }
        static bool IsTeamName(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsLower(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
