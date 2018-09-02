using System;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = numberOfPeople / elevatorCapacity;
            courses += numberOfPeople % elevatorCapacity == 0 ? 0 : 1;
            Console.WriteLine(courses);
        }
    }
}
