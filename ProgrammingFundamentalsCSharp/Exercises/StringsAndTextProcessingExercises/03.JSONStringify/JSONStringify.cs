using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSONStringify
{
    class JSONStringify
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "stringify")
            {
                string[] inputTokens = input.Split(new string[]
                    { " : ", " -> " ," ->"},
                    StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                string age = inputTokens[1];
                List<string> grades = new List<string>();
                if (inputTokens.Length == 3)
                {
                    grades = inputTokens[2]
                       .Split(new string[] { ", " },
                       StringSplitOptions.RemoveEmptyEntries)
                       .ToList();
                }
                Student currentStudent = new Student(name, age, grades);
                students.Add(currentStudent);
            }
            Console.Write("[");
            for (int i = 0; i < students.Count - 1; i++)
            {
                Console.Write("{");
                Console.Write($"name:\"{students[i].Name}\",age:{students[i].Age},grades:[{string.Join(", ", students[i].Grades)}]");
                Console.Write("},");
            }
            Console.Write("{");
            Console.Write($"name:\"{students[students.Count - 1].Name}\",age:{students[students.Count - 1].Age},grades:[{string.Join(", ", students[students.Count - 1].Grades)}]");
            Console.Write("}");
            Console.Write("]" + Environment.NewLine);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public List<string> Grades { get; set; }
        public Student(string name, string age, List<string> grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }
    }
}
