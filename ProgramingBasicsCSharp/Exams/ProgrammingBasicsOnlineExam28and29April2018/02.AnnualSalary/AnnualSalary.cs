using System;

namespace _02.AnnualSalary
{
    class AnnualSalary
    {
        static void Main(string[] args)
        {
            int yearsOfExpirience = int.Parse(Console.ReadLine());
            string profession = Console.ReadLine();
            decimal moneyPerYear = 0m;
            switch (profession)
            {
                case "C# Developer": moneyPerYear = 12 * 5400m; break;
                case "Java Developer": moneyPerYear = 12 * 5700m; break;
                case "Front-End Web Developer": moneyPerYear = 12 * 4100m; break;
                case "UX / UI Designer": moneyPerYear = 12 * 3100m; break;
                case "Game Designer": moneyPerYear = 12 * 3600m; break;
            }
            moneyPerYear = yearsOfExpirience > 5 ? moneyPerYear : moneyPerYear - moneyPerYear * 0.658m;
            Console.WriteLine($"Total earned money: {moneyPerYear:F2} BGN");
        }
    }
}
