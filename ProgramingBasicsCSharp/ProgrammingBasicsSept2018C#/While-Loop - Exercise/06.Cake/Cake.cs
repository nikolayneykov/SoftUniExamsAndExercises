using System;

class Cake
{
    static void Main(string[] args)
    {
        int cakeWidth = int.Parse(Console.ReadLine());
        int cakeLength = int.Parse(Console.ReadLine());
        int cakePieces = cakeWidth * cakeLength;
        string input = string.Empty;
        while (cakePieces >= 0 && (input = Console.ReadLine()) != "STOP")
        {
            cakePieces -= int.Parse(input);
        }
        Console.WriteLine(cakePieces >= 0 ?
            $"{cakePieces} pieces are left." :
            $"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
    }
}

