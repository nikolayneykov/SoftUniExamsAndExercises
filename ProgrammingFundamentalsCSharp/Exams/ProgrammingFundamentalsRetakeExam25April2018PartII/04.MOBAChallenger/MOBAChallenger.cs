using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            Dictionary<string, PlayerPosition> players =
                new Dictionary<string, PlayerPosition>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] tokens = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 3)
                {
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);
                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new PlayerPosition());
                    }
                    players[player].AddPosition(position, skill);
                }
                else
                {
                    tokens = input.Split(new string[] { " vs " },
                    StringSplitOptions.RemoveEmptyEntries);
                    string player1 = tokens[0];
                    string player2 = tokens[1];
                    if (players.ContainsKey(player1) &&
                        players.ContainsKey(player2) &&
                        (HaveCommonPositions(players, player1, player2)))
                    {
                        if (players[player1].TotalSkill > players[player2].TotalSkill)
                        {
                            players.Remove(player2);
                        }
                        else if (players[player1].TotalSkill < players[player2].TotalSkill)
                        {
                            players.Remove(player1);
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, PlayerPosition> player in players
                .OrderByDescending(x => x.Value.TotalSkill)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.TotalSkill} skill");
                foreach (KeyValuePair<string, int> position in player
                    .Value
                    .Positions
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }

        private static bool HaveCommonPositions(
            Dictionary<string, PlayerPosition> players,
            string player1, string player2)
        {
            foreach (KeyValuePair<string, int> position1 in players[player1].Positions)
            {
                foreach (KeyValuePair<string, int> position2 in players[player2].Positions)
                {
                    if (position1.Key == position2.Key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    class PlayerPosition
    {
        public Dictionary<string, int> Positions { get; set; }
        public int TotalSkill { get; set; }
        public PlayerPosition()
        {
            Positions = new Dictionary<string, int>();
        }
        public void AddPosition(string position, int skill)
        {
            if (!Positions.ContainsKey(position))
            {
                Positions.Add(position, skill);
                TotalSkill += skill;
            }
            else if (Positions.ContainsKey(position) &&
                Positions[position] < skill)
            {
                TotalSkill -= Positions[position];
                TotalSkill += skill;
                Positions[position] = skill;
            }
        }
    }
}
