using System;
using System.Linq;

namespace _05.PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split().ToArray();
            int ingredientLength = int.Parse(Console.ReadLine());
            ingredients = ingredients.Where(i => i.Length == ingredientLength).Take(10).ToArray();
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine($"Adding {ingredient}.");
            }
            Console.WriteLine($"Made pizza with total of {ingredients.Length} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingredients)}.");
        }
    }
}
