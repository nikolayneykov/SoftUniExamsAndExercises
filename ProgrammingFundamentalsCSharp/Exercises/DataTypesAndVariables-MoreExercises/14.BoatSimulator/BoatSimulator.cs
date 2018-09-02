using System;

namespace _14.BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int firstBoatTiles = 0;
            int secondBoatTiles = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                if (command == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                else if (i % 2 == 1)
                {
                    firstBoatTiles += command.Length;
                }
                else if (i % 2 == 0)
                {
                    secondBoatTiles += command.Length;
                }
                if (firstBoatTiles>=50 || secondBoatTiles>=50)
                {
                    break;
                }
            }
            if (firstBoatTiles>secondBoatTiles)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
