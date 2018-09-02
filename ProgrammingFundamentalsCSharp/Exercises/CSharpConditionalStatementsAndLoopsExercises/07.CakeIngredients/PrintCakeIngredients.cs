using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class PrintCakeIngredients
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int ingredientsNumber = 0;
            while ((command = Console.ReadLine()) != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {command}.");
                ingredientsNumber++;
            }
            Console.WriteLine($"Preparing cake with {ingredientsNumber} ingredients.");
        }
    }
}
