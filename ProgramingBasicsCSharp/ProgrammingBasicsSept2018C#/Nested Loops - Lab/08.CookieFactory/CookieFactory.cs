using System;

class CookieFactory
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            bool hasFlour = false;
            bool hasSugar = false;
            bool hasEggs = false;
            
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "flour": hasFlour = true; break;
                    case "sugar": hasSugar = true; break;
                    case "eggs": hasEggs = true; break;
                }

                if (input == "Bake!")
                {
                    if (hasFlour && hasSugar && hasEggs)
                    {
                        Console.WriteLine($"Baking batch number {i}...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                }            
            }
        }
    }
}

