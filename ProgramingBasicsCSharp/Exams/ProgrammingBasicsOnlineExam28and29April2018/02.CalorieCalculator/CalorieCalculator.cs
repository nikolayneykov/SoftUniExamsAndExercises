using System;

namespace _02.CalorieCalculator
{
    class CalorieCalculator
    {
        static void Main(string[] args)
        {
            char gender = char.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string physicalActivity = Console.ReadLine();
            double caloriesNeeded = 0;
            switch (gender)
            {
                case 'm':
                    caloriesNeeded = 66 + (13.7 * weight) + (5 * height * 100) - (6.8 * age);
                    break;
                case 'f':
                    caloriesNeeded = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);
                    break;
            }
            switch (physicalActivity)
            {
                case "sedentary": caloriesNeeded *= 1.2; break;
                case "lightly active": caloriesNeeded *= 1.375; break;
                case "moderately active": caloriesNeeded *= 1.55; break;
                case "very active": caloriesNeeded *= 1.725; break;
            }
            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(caloriesNeeded)} calories per day.");
        }
    }
}
