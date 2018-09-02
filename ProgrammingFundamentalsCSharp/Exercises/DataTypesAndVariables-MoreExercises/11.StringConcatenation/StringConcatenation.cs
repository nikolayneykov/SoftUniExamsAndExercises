using System;
using System.Collections.Generic;

namespace _11.StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            string typeOfIndex = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (typeOfIndex == "odd" && i % 2 == 1)
                {
                    result.Add(word);
                }
                else if (typeOfIndex == "even" && i % 2 == 0)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(delimeter,result));
        }
    }
}
