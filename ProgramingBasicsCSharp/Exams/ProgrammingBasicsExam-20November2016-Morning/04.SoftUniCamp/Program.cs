using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            double grp1 = 0;
            double grp2 = 0;
            double grp3 = 0;
            double grp4 = 0;
            double grp5 = 0;
            double totalPassangers = 0;
            for (int i = 0; i < groupsCount; i++)
            {
                int group = int.Parse(Console.ReadLine());
                totalPassangers += group;
                if (group <= 5)
                {
                    grp1+=group;
                }
                else if (group >= 6 && group <= 12)
                {
                    grp2+=group;
                }
                else if (group >= 13 && group <= 25)
                {
                    grp3+=group;
                }
                else if (group >= 26 && group <= 40)
                {
                    grp4+=group;
                }
                else
                {
                    grp5+=group;
                }
            }
            Console.WriteLine("{0:F2}%", (grp1 / totalPassangers) * 100.0);
            Console.WriteLine("{0:F2}%", (grp2 / totalPassangers) * 100.0);
            Console.WriteLine("{0:F2}%", (grp3 / totalPassangers) * 100.0);
            Console.WriteLine("{0:F2}%", (grp4 / totalPassangers) * 100.0);
            Console.WriteLine("{0:F2}%", (grp5 / totalPassangers) * 100.0);
        }
    }
}
