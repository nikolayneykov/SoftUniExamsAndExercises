using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача01_ДневнаПечалба
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            double moneyPerWorkDay = double.Parse(Console.ReadLine());
            double dolarToLevRate = double.Parse(Console.ReadLine());

            double monthlySalary = workingDaysPerMonth * moneyPerWorkDay;
            double bonusSalary = monthlySalary * 2.5;
            double yearlySalary = monthlySalary * 12 + bonusSalary;
            double taxes = yearlySalary * 0.25;
            double yearlySalaryAfterTaxes = yearlySalary - taxes;
            double avarageProfitPerDay = yearlySalaryAfterTaxes / 365;
            double resultInLev = avarageProfitPerDay * dolarToLevRate;

            Console.WriteLine("{0:F2}",resultInLev);
        }
    }
}
