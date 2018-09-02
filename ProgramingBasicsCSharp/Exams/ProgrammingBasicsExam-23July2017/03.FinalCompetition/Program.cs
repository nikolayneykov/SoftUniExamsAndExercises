using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double prize = 0;
            if (place == "Bulgaria")
            {
                prize = dancers * points;
                prize = season == "summer" ? prize -= prize * 0.05 : prize -= prize * 0.08;
            }
            else
            {
                prize = dancers * points;
                prize += prize / 2;
                prize = season == "summer" ? prize -= prize * 0.1 : prize -= prize * 0.15;
            }
            Console.WriteLine("Charity - {0:F2}",prize*0.75);
            Console.WriteLine("Money per dancer - {0:F2}",(prize*0.25)/dancers);
        }
    }
}
