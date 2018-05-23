using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FruitOrVegetable
{
    class CheckIfFruitOrVegetable
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string result = string.Empty;
            if (product.Equals("banana") || product.Equals("apple") ||
                product.Equals("kiwi") || product.Equals("cherry") ||
                product.Equals("lemon") || product.Equals("grapes"))
            {
                result = "fruit";
            }
            else if (product.Equals("tomato") || product.Equals("cucumber") ||
                product.Equals("pepper") || product.Equals("carrot"))
            {
                result = "vegetable";
            }
            else
            {
                result = "unknown";
            }
            Console.WriteLine(result);
        }
    }
}
