using System;

namespace _03.OnlineEducation
{
    class OnlineEducation
    {
        static void Main(string[] args)
        {
            int onlineStudentsCount = 0;
            int onsiteStudentsCount = 0;
            for (int i = 0; i < 3; i++)
            {
                string formOfEducation = Console.ReadLine();
                int numberOfStudents = int.Parse(Console.ReadLine());
                if (formOfEducation == "online")
                {
                    onlineStudentsCount += numberOfStudents;
                }
                else if (formOfEducation== "onsite")
                {
                    if (onsiteStudentsCount==600)
                    {
                        onlineStudentsCount += numberOfStudents;
                    }
                    else if (onsiteStudentsCount+numberOfStudents>600)
                    {
                        numberOfStudents -= 600 - onsiteStudentsCount;
                        onlineStudentsCount += numberOfStudents;
                        onsiteStudentsCount = 600;
                    }
                    else
                    {
                        onsiteStudentsCount += numberOfStudents;
                    }
                }
            }
            Console.WriteLine($"Online students: {onlineStudentsCount}");
            Console.WriteLine($"Onsite students: {onsiteStudentsCount}");
            Console.WriteLine($"Total students: {onlineStudentsCount+onsiteStudentsCount}");
        }
    }
}
