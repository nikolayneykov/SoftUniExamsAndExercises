using System;

namespace _04.CreditSystem
{
    class CreditSystem
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double creditSum = 0;
            double gradeSum = 0;
            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                int maxCredits = inputNumber / 10;
                int studentGrade = inputNumber % 10;
                switch (studentGrade)
                {
                    case 3: creditSum += maxCredits * 0.5; break;
                    case 4: creditSum += maxCredits * 0.7; break;
                    case 5: creditSum += maxCredits * 0.85; break;
                    case 6: creditSum += maxCredits; break;
                }
                gradeSum += studentGrade;
            }
            double averageGrade = gradeSum / (double)n;
            Console.WriteLine($"{creditSum:F2}");
            Console.WriteLine($"{averageGrade:F2}");
        }
    }
}
