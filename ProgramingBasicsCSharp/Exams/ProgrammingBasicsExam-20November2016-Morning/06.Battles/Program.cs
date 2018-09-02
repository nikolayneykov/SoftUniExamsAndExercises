using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokNum1 = int.Parse(Console.ReadLine());
            int pokNum2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pokNum1 && maxBattles>0; i++)
            {
                for (int j = 1; j <= pokNum2 && maxBattles>0; j++,maxBattles--)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                }
            }

        }
    }
}
