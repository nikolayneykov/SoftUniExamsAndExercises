using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .Select(x => x)
                .ToList();

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "course start")
            {
                string[] tokens = commands.Split(':');
                string command = tokens[0];
                string lessonTitle = tokens[1];

                if (command == "Add" && !lessons.Contains(lessonTitle))
                {
                    lessons.Add(lessonTitle);
                }
                else if (command == "Insert" && !lessons.Contains(lessonTitle))
                {
                    int index = int.Parse(tokens[2]);
                    if (index >= 0 && index < lessons.Count)
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    lessons.Remove(lessonTitle);
                    lessons.Remove($"{lessonTitle}-Exercise");
                }
                else if (command == "Swap")
                {
                    string lessonTitle2 = tokens[2];

                    int index1 = lessons.IndexOf(lessonTitle);
                    int index2 = lessons.IndexOf(lessonTitle2);
                    if (index1 != -1 && index2 != -1)
                    {
                        lessons[index1] = lessonTitle2;
                        lessons[index2] = lessonTitle;

                        if (index1 + 1 < lessons.Count && lessons[index1 + 1] == $"{lessonTitle}-Exercise")
                        {
                            lessons.RemoveAt(index1 + 1);
                            index1 = lessons.IndexOf(lessonTitle);
                            lessons.Insert(index1 + 1, $"{lessonTitle}-Exercise");
                        }

                        if (index2 + 1 < lessons.Count && lessons[index2 + 1] == $"{lessonTitle2}-Exercise")
                        {
                            lessons.RemoveAt(index2 + 1);
                            index2 = lessons.IndexOf(lessonTitle2);
                            lessons.Insert(index2 + 1, $"{lessonTitle2}-Exercise");
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    int index = lessons.IndexOf(lessonTitle);
                    if (index != -1 && !lessons.Contains($"{lessonTitle}-Exercise"))
                    {
                        lessons.Insert(index + 1, $"{lessonTitle}-Exercise");
                    }
                    else if (index == -1)
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add($"{lessonTitle}-Exercise");
                    }
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
