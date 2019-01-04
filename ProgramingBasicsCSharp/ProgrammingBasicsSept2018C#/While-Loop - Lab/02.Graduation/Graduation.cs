using System;

class Graduation
{
    static void Main(string[] args)
    {
        string studentName = Console.ReadLine();
        double gradeSum = 0;
        int count = 1;
        while (count <= 12)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 4.00)
            {
                gradeSum += grade;
                count++;
            }
        }
        double averageGrade = gradeSum / 12;
        Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
    }
}

