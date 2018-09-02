using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            string displayHealth = "|" + new string('|', currentHealth) + 
                new string('.', maxHealth - currentHealth) + "|";
            Console.WriteLine($"Health: {displayHealth}");
            string displayEnergy = "|" + new string('|', currentEnergy) +
                new string('.', maxEnergy - currentEnergy) + "|";
            Console.WriteLine($"Energy: {displayEnergy}");
        }
    }
}
