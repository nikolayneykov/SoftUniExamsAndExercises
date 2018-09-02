using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            List<long> bees = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            List<long> hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            for (int i = 0; i < bees.Count; i++)
            {
                long hornetPower = hornets.Sum();
                if (bees[i] < hornetPower)
                {
                    bees.RemoveAt(i);
                    i--;
                }
                else if (bees[i] == hornetPower)
                {
                    bees.RemoveAt(i);
                    hornets.RemoveAt(0);
                    i--;
                }
                else
                {
                    bees[i] -= hornetPower;
                    hornets.RemoveAt(0);
                }
                if (bees.Count == 0 || hornets.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(bees.Count > 0 ?
                string.Join(" ", bees) :
                string.Join(" ", hornets));
        }
    }
}
