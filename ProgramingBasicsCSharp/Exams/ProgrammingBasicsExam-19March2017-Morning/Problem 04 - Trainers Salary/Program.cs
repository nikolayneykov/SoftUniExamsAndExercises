using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double moneyPerLection = budget / lections;
            double salaryJelev = 0;
            double salaryRoYaL = 0;
            double salaryRoli = 0;
            double salaryTrofon = 0;
            double salarySino = 0;
            double salaryOthers = 0;

            for (int i = 0; i < lections; i++)
            {
                string nameOfLector = Console.ReadLine();
                switch (nameOfLector)
                {
                    case "Jelev": salaryJelev += moneyPerLection; break;
                    case "RoYaL": salaryRoYaL += moneyPerLection; break;
                    case "Roli": salaryRoli += moneyPerLection; break;
                    case "Trofon": salaryTrofon += moneyPerLection; break;
                    case "Sino": salarySino += moneyPerLection; break;
                    default: salaryOthers += moneyPerLection; break;
                }
            }

            Console.WriteLine("Jelev salary: {0:F2} lv", salaryJelev);
            Console.WriteLine("RoYaL salary: {0:F2} lv", salaryRoYaL);
            Console.WriteLine("Roli salary: {0:F2} lv", salaryRoli);
            Console.WriteLine("Trofon salary: {0:F2} lv", salaryTrofon);
            Console.WriteLine("Sino salary: {0:F2} lv", salarySino);
            Console.WriteLine("Others salary: {0:F2} lv", salaryOthers);
        }
    }
}
