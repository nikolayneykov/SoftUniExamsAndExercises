using System;

class TrainTheTrainers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double finalAssessment = 0;
        int presentationCount = 0;
        string presentation = string.Empty;
        while ((presentation = Console.ReadLine()) != "Finish")
        {
            double averageGrade = 0;
            for (int i = 0; i < n; i++)
            {
                averageGrade += double.Parse(Console.ReadLine());
            }
            averageGrade /= n;
            Console.WriteLine($"{presentation} - {averageGrade:F2}.");
            finalAssessment += averageGrade;
            presentationCount++;
        }
        finalAssessment /= presentationCount;
        Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
    }
}

