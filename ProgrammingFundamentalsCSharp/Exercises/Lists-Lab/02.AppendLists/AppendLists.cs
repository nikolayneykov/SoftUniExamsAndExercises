using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split('|');
            List<string> list = new List<string>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                string[] subArray = array[i].Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                list.AddRange(subArray);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
