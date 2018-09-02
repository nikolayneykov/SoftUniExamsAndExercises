using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            int health = initialHealth;

            string virus = string.Empty;
            List<string> defeatedViruses = new List<string>();
            while ((virus = Console.ReadLine()) != "end")
            {
                int virusStrength = virus.Sum(x => x) / 3;
                int secondsToDefeat = virusStrength * virus.Length;
                if (defeatedViruses.Contains(virus))
                {
                    secondsToDefeat /= 3;
                }
                else
                {
                    defeatedViruses.Add(virus);
                }

                Console.WriteLine($"Virus {virus}: {virusStrength} => {secondsToDefeat} seconds");
                health -= secondsToDefeat;
                if (health < 0)
                {
                    break;
                }
                TimeSpan defeatTime = new TimeSpan(0, 0, secondsToDefeat);
                Console.WriteLine($"{virus} defeated in {(int)defeatTime.TotalMinutes}m {defeatTime.Seconds}s.");
                Console.WriteLine($"Remaining health: {health}");
                health += (int)(health * 0.2);
                if (health > initialHealth)
                {
                    health = initialHealth;
                }
            }
            Console.WriteLine(health > 0 ? $"Final Health: {health}" : "Immune System Defeated.");
        }
    }
}
