using System;

class Graduationpt2
{
    static void Main(string[] args)
    {
        string studentName = Console.ReadLine();
        double gradeSum = 0;
        bool isExcluded = false;
        int count = 1;
        while (count <= 12)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 4.00)
            {
                gradeSum += grade;
                count++;
            }
            else
            {
                isExcluded = true;
                break;
            }
        }
        double averageGrade = gradeSum / 12;

        Console.WriteLine(isExcluded ?
            $"{studentName} has been excluded at {count} grade" :
            $"{studentName} graduated. Average grade: {averageGrade:F2}");
    }
}

