using System;

class FruitOrVegetable
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string result = "unknown";
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
        Console.WriteLine(result);
    }
}

