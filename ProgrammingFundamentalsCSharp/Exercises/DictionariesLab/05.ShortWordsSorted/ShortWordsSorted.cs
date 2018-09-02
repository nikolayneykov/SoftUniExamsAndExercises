using System;
using System.Linq;
namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"\'\\/!? ".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
            Console.WriteLine(string.Join(", ",words));
        }
    }
}
