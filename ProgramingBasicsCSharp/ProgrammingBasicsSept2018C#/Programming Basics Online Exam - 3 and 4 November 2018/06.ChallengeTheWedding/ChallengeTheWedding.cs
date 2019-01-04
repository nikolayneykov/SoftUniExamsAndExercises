using System;

class ChallengeTheWedding
{
    static void Main(string[] args)
    {
        int men = int.Parse(Console.ReadLine());
        int women = int.Parse(Console.ReadLine());
        int tables = int.Parse(Console.ReadLine());


        for (int i = 1; tables > 0 && i <= men; i++)
        {
            for (int j = 1; tables > 0 && j <= women; j++, tables--)
            {
                Console.Write($"({i} <-> {j}) ");
            }
        }
    }
}

