using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string user = tokens[0];
                string teamName = tokens[1];
                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Values.Any(c => c.Contains(user)))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                    teams.Add(teamName, new List<string>());
                    teams[teamName].Add(user);
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string teamName = tokens[1];
                if (!teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Values.Any(c => c.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    teams[teamName].Add(user);
                }
            }

            foreach (var team in teams
                .Where(t => t.Value.Count > 1)
                .OrderByDescending(t => t.Value.Count)
                .ThenBy(t => t.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- {team.Value[0]}");
                foreach (var user in team.Value.Skip(1).OrderBy(u=>u))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(t => t.Value.Count == 1).OrderBy(x => x.Key))
            {
                Console.WriteLine(team.Key);
            }
        }
    }
}
