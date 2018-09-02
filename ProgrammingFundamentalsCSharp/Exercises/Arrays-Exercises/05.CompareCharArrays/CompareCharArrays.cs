using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string arr1 = new string(Console.ReadLine().ToCharArray()).Replace(" ", "");
            string arr2 = new string(Console.ReadLine().ToCharArray()).Replace(" ", "");
            string[] array = { arr1, arr2 };
            foreach (string arr in array.OrderBy(x => x))
            {
                Console.WriteLine(arr);
            }
        }
    }
}
