using System;

class Walking
{
    static void Main(string[] args)
    {
        int steps = 0;

        while (steps < 10_000)
        {
            string input = Console.ReadLine();
            if (input == "Going home")
            {
                steps += int.Parse(Console.ReadLine());
                break;
            }
            steps += int.Parse(input);
        }
        Console.WriteLine(steps >= 10_000 ?
            "Goal reached! Good job!" :
            $"{10_000 - steps} more steps to reach goal.");
    }
}

