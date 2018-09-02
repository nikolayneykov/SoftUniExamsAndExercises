using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class FightingGame
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int peshoHP = 100;
            int goshoDamage = int.Parse(Console.ReadLine());
            int goshoHP = 100;

            int round = 1;

            while (peshoHP > 0 && goshoHP > 0)
            {
                if (round % 2 == 1)
                {
                    goshoHP -= peshoDamage;
                    if (goshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP} health.");                  
                }
                else
                {
                    peshoHP -= goshoDamage;
                    if (peshoHP<=0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP} health.");                    
                }
                if (round%3==0)
                {
                    peshoHP+=10;
                    goshoHP+=10;
                }
                round++;
            }
        }
    }
}
