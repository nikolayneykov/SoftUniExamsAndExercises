using System;

class Moving
{
    static void Main(string[] args)
    {
        int freeSpaceWidth = int.Parse(Console.ReadLine());
        int freeSpaceLength = int.Parse(Console.ReadLine());
        int freeSpaceHeight = int.Parse(Console.ReadLine());
        int freeSpaceVolume = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;
        string input = string.Empty;
        while (freeSpaceVolume > 0 && (input = Console.ReadLine()) != "Done")
        {
            freeSpaceVolume -= int.Parse(input);
        }
        Console.WriteLine(freeSpaceVolume >= 0 ?
            $"{freeSpaceVolume} Cubic meters left." :
            $"No more free space! You need {Math.Abs(freeSpaceVolume)} Cubic meters more.");
    }
}

