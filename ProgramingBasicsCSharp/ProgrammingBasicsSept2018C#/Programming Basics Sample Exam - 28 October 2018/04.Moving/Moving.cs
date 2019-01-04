using System;

class Moving
{
    static void Main(string[] args)
    {
        int freeWidth = int.Parse(Console.ReadLine());
        int freeLength = int.Parse(Console.ReadLine());
        int freeHeight = int.Parse(Console.ReadLine());
        int freeVolume = freeWidth * freeLength * freeHeight;
        string input = string.Empty;
        while (freeVolume > 0 && (input = Console.ReadLine()) != "Done")
        {
            freeVolume -= int.Parse(input);
        }
        Console.WriteLine(freeVolume >= 0 ?
            $"{freeVolume} Cubic meters left." :
            $"No more free space! You need {Math.Abs(freeVolume)} Cubic meters more.");

    }
}

