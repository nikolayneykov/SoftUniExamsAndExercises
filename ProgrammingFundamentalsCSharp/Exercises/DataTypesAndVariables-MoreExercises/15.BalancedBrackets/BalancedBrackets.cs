using System;

namespace _15.BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool balanced = true;
            bool searchOpening = true;
            bool searchClosing = false;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (searchOpening)
                {
                    if (line == "(")
                    {
                        searchOpening = false;
                        searchClosing = true;
                    }
                    else if (line==")")
                    {
                        balanced = false;
                    }
                }
                else if (searchClosing)
                {
                    if (line == ")")
                    {
                        searchOpening = true;
                        searchClosing = false;
                    }
                    else if (line=="(")
                    {
                        balanced = false;
                    }
                }
            }
            Console.WriteLine(balanced ? "BLANCED" : "UNBALANCED");
        }
    }
}
