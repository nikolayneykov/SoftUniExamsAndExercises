using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players =
                 new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "JOKER")
            {
                string[] tokens = input
                    .Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                List<string> currentCards = tokens[1]
                    .Split(", ".ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!players.ContainsKey(name))
                {
                    players.Add(name, new List<string>());
                }
                players[name].AddRange(currentCards);
            }
            foreach (KeyValuePair<string, List<string>> player in players)
            {
                string playerName = player.Key;
                int totalSum = 0;
                foreach (string card in player.Value.Distinct())
                {
                    int currentCardValue = 0;
                    switch (card[0])
                    {
                        case '2': currentCardValue += 2; break;
                        case '3': currentCardValue += 3; break;
                        case '4': currentCardValue += 4; break;
                        case '5': currentCardValue += 5; break;
                        case '6': currentCardValue += 6; break;
                        case '7': currentCardValue += 7; break;
                        case '8': currentCardValue += 8; break;
                        case '9': currentCardValue += 9; break;
                        case '1': currentCardValue += 10; break;
                        case 'J': currentCardValue += 11; break;
                        case 'Q': currentCardValue += 12; break;
                        case 'K': currentCardValue += 13; break;
                        case 'A': currentCardValue += 14; break;
                    }
                    switch (card[card.Length - 1])
                    {
                        case 'S': currentCardValue *= 4; break;
                        case 'H': currentCardValue *= 3; break;
                        case 'D': currentCardValue *= 2; break;
                    }
                    totalSum += currentCardValue;
                }
                Console.WriteLine($"{playerName}: {totalSum}");
            }
        }
    }
}
