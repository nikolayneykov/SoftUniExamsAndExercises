using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TseamAccount
{
    class TseamAccount
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Play!")
            {
                string[] tokens = commands.Split();
                string currentCommand = tokens[0];
                string currentGame = tokens[1];
                switch (currentCommand)
                {
                    case "Install":
                        if (!games.Contains(currentGame))
                        {
                            games.Add(currentGame);
                        }
                        break;
                    case "Uninstall":
                        if (games.Contains(currentGame))
                        {
                            games.Remove(currentGame);
                        }
                        break;
                    case "Update":
                        if (games.Contains(currentGame))
                        {
                            games.Remove(currentGame);
                            games.Add(currentGame);
                        }
                        break;
                    case "Expansion":
                        string[] expansionTokens = currentGame.Split('-');
                        currentGame = expansionTokens[0];
                        string expansion = expansionTokens[1];
                        if (games.Contains(currentGame))
                        {
                            int index = games.IndexOf(currentGame)+1;
                            games.Insert(index, $"{currentGame}:{expansion}");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", games));
        }
    }
}
