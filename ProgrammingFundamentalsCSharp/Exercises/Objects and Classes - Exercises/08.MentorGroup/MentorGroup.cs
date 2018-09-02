using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!= "end of dates")
            {
                string[] tokens = input.Split(' ', ',');
                string name = tokens[0];
                DateTime[] dates = tokens
                    .Skip(1)
                    .Select(x=> DateTime.ParseExact(x,"d/M/yyyy",CultureInfo.InvariantCulture))
                    .ToArray();
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new Student());
                }
                students[name].AddDates(dates);
            }
            while ((input = Console.ReadLine()) != "end of comments")
            {
                string[] tokens = input.Split('-');
                string name = tokens[0];
                string comment = tokens[1];
                if (students.ContainsKey(name))
                {
                    students[name].AddComment(comment);
                }
            }

            foreach (var student in students.OrderBy(s=>s.Key))
            {
                Console.WriteLine(student.Key+"\nComments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.DatesAttended.OrderBy(d=>d))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> DatesAttended { get; set; }

        public Student()
        {
            this.Comments = new List<string>();
            this.DatesAttended = new List<DateTime>();
        }
        public void AddDates(DateTime[] dates)
        {
            this.DatesAttended.AddRange(dates);
        }
        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
