using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Icarus
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int position = int.Parse(Console.ReadLine());
            int damage = 1;
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Supernova")
            {
                string[] commandTokens = commands.Split(' ');
                string direction = commandTokens[0];
                int steps = int.Parse(commandTokens[1]);
                if (direction.Equals("left"))
                {
                    while (steps > 0)
                    {
                        position--;
                        if (position == -1)
                        {
                            position = plane.Length - 1;
                            damage++;
                        }
                        plane[position] -= damage;
                        steps--;
                    }
                }
                else if (direction.Equals("right"))
                {
                    while (steps>0)
                    {
                        position++;
                        if (position == plane.Length)
                        {
                            position = 0;
                            damage++;
                        }
                        plane[position] -= damage;
                        steps--;
                    }                 
                }
            }
            Console.WriteLine(string.Join(" ",plane));
        }
    }
}
