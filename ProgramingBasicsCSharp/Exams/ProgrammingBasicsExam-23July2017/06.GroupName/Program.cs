using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            char fourthSymbol = char.Parse(Console.ReadLine());
            char fifthSymbol = char.Parse(Console.ReadLine());
            int suggestions = 0;

            for (int i = 'A'; i <= firstSymbol; i++)
                for (int j = 'a'; j <= secondSymbol; j++)
                    for (int k = 'a'; k <= thirdSymbol; k++)
                        for (int l = 'a'; l <= fourthSymbol; l++)
                            for (int m = '0'; m <= fifthSymbol; m++)
                                suggestions++;
            Console.WriteLine(suggestions-1);
        }
    }
}
