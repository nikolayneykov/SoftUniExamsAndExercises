using System;

class Spaceship
{
    static void Main(string[] args)
    {
        double rocketWidth = double.Parse(Console.ReadLine());
        double rocketLength = double.Parse(Console.ReadLine());
        double rocketHeight = double.Parse(Console.ReadLine());
        double astronautHeight = double.Parse(Console.ReadLine());

        double spaceshipVolume = rocketWidth * rocketLength * rocketHeight;
        double roomVolume = (astronautHeight + 0.40) * 4;

        int totalAustronauts = (int)Math.Floor(spaceshipVolume / roomVolume);
        string result = (totalAustronauts >= 3 && totalAustronauts <= 10) ?
                        $"The spacecraft holds {totalAustronauts} astronauts." :
                        totalAustronauts < 3 ? "The spacecraft is too small." :
                        "The spacecraft is too big.";
        Console.WriteLine(result);
    }
}

