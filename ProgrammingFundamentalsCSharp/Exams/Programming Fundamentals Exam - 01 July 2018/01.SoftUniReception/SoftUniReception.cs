using System;

namespace _01.SoftUniReception
{
    class SoftUniReception
    {
        static void Main(string[] args)
        {
            int employee1Capacity = int.Parse(Console.ReadLine());
            int employee2Capacity = int.Parse(Console.ReadLine());
            int employee3Capacity = int.Parse(Console.ReadLine());
            int totalStudents = int.Parse(Console.ReadLine());
            int timeNeeded = 0;
            while (totalStudents > 0)
            {
                totalStudents -= employee1Capacity + employee2Capacity + employee3Capacity;
                timeNeeded++;
                if (timeNeeded % 4 == 0)
                {
                    timeNeeded++;               
                }               
            }
            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
