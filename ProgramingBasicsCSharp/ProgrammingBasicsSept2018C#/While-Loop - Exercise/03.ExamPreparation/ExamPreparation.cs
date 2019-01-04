using System;

class ExamPreparation
{
    static void Main(string[] args)
    {
        int poorGradeLimit = int.Parse(Console.ReadLine());
        int poorGradeCount = 0;
        int problemCount = 0;
        double gradesSum = 0;
        string lastProblemName = string.Empty;
        string problemName = string.Empty;
        while (poorGradeCount < poorGradeLimit &&
            (problemName = Console.ReadLine()) != "Enough")
        {
            double grade = double.Parse(Console.ReadLine());
            gradesSum += grade;
            problemCount++;
            lastProblemName = problemName;
            if (grade <= 4.00)
            {
                poorGradeCount++;
            }
        }
        Console.WriteLine(poorGradeCount < poorGradeLimit ?
            $"Average score: {gradesSum / problemCount:F2}" +
            $"\nNumber of problems: {problemCount}" +
            $"\nLast problem: {lastProblemName}" :
            $"You need a break, {poorGradeCount} poor grades.");
    }
}

