using System;

class NameWars
{
    static void Main(string[] args)
    {
        string name = string.Empty;
        string winnerName = string.Empty;
        int winnerScore = 0;
        while ((name = Console.ReadLine()) != "STOP")
        {
            int currentScore = 0;
            for (int i = 0; i < name.Length; i++)
            {
                currentScore += name[i];
            }
            if (currentScore > winnerScore)
            {
                winnerName = name;
                winnerScore = currentScore;
            }
        }
        Console.WriteLine($"Winner is {winnerName} - {winnerScore}! ");
    }
}

