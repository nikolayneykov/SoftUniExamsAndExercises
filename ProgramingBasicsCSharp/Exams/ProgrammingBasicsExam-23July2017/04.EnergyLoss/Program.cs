using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            int numberOfDancers = int.Parse(Console.ReadLine());
            int dancersEnergy = numberOfDancers * trainingDays * 100;
            int totalEnergy = 0;

            for (int day = 1; day <= trainingDays; day++)
            {
                int trainingHours = int.Parse(Console.ReadLine());
                if ((day & 1) == 1)
                {
                    totalEnergy += (trainingHours & 1) == 1 ?
                        numberOfDancers * 30 : numberOfDancers * 49;
                }
                else
                {
                    totalEnergy += (trainingHours & 1) == 1 ?
                        numberOfDancers * 65 : numberOfDancers * 68;
                }
            }

            double savedEnergy = dancersEnergy - totalEnergy;
            double savedEnergyPerDancer = savedEnergy / trainingDays / numberOfDancers;
            Console.WriteLine(savedEnergyPerDancer<50? 
                "They are wasted! Energy left: {0:F2}":
                "They feel good! Energy left: {0:F2}",savedEnergyPerDancer);
        }
    }
}
