using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ReadStudent();
            }
            foreach (var student in students.
                Where(s => s.AverageGrade >= 5).
                OrderBy(s => s.Name).
                ThenByDescending(s => s.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
        static Student ReadStudent()
        {
            string[] inputTokens = Console.ReadLine().Split();
            string name = inputTokens[0];
            List<double> grades = inputTokens.Skip(1).Select(double.Parse).ToList();
            return new Student()
            {
                Name = name,
                Grades = grades
            };
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }
}
