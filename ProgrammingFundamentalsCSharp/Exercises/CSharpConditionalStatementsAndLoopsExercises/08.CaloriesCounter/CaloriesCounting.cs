using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounting
    {
        static void Main(string[] args)
        {
            int ingredientsNumber = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < ingredientsNumber; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":totalCalories += 500;break;
                    case "tomato sauce":totalCalories += 150;break;
                    case "salami":totalCalories += 600;break;
                    case "pepper":totalCalories += 50;break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
