using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = int.Parse(Console.ReadLine());
            int excellent = 0;
            int veryGood = 0;
            int good = 0;
            int fail = 0;
            double average = 0;
            for (int i = 0; i < totalStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5 && grade <= 6)
                {
                    excellent++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    veryGood++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    good++;
                }
                if (grade >= 2 && grade <= 2.99)
                {
                    fail++;
                }
                average += grade;
            }
            Console.WriteLine("Top students: {0:F2}%", excellent / (double)totalStudents * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", veryGood / (double)totalStudents * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", good / (double)totalStudents * 100);
            Console.WriteLine("Fail: {0:F2}%", fail / (double)totalStudents * 100);
            Console.WriteLine("Average: {0:F2}",average/(double)totalStudents);
        }
    }
}
