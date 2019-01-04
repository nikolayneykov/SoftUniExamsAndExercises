using System;

class GroupStage
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine();
        int playedGames = int.Parse(Console.ReadLine());
        int scoredGoals = 0;
        int recievedGoals = 0;
        int points = 0;

        for (int i = 0; i < playedGames; i++)
        {
            int currentScoredGoals = int.Parse(Console.ReadLine());
            int currentRecievedGoals = int.Parse(Console.ReadLine());
            if (currentScoredGoals > currentRecievedGoals)
            {
                points += 3;
            }
            else if (currentScoredGoals == currentRecievedGoals)
            {
                points++;
            }
            scoredGoals += currentScoredGoals;
            recievedGoals += currentRecievedGoals;
        }
        int goalDifference = scoredGoals - recievedGoals;
        Console.WriteLine(goalDifference >= 0 ?
            $"{country} has finished the group phase with {points} points.\nGoal difference: {goalDifference}." :
            $"{country} has been eliminated from the group phase.\nGoal difference: {goalDifference}.");
    }
}

