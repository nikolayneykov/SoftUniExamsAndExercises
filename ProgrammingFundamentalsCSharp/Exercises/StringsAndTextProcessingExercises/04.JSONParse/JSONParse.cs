using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSONParse
{
    class JSONParse
    {
        static void Main(string[] args)
        {
            string splitChars = "[]{}:\", ";
            string input = Console.ReadLine();
            string[] inputTokens = input
                .Split(splitChars.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            input = string.Join(" ", inputTokens);
            inputTokens = input
                .Split(new string[] { "name" },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string student in inputTokens)
            {
                string[] studentTokens = student.Split(' ');
                string name = studentTokens[1];
                string age = studentTokens[3];
                List<string> grades = studentTokens
                    .Skip(5)
                    .Where(x=>!string.IsNullOrWhiteSpace(x))
                    .ToList();
                if (grades.Count==0)
                {
                    grades.Add("None");
                }
                Console.WriteLine($"{name} : {age} -> {string.Join(", ",grades)}");
            }
        }
    }
}
