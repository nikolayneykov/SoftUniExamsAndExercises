using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MemoryView
{
    class MemoryView
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Regex reg = new Regex(@"32656 19759 32763 0 (\d+) 0");
            StringBuilder concatenatedInput = new StringBuilder();
            while ((input = Console.ReadLine()) != "Visual Studio crash")
            {
                concatenatedInput.Append(input + " ");
            }
            int[] arr = concatenatedInput
                .ToString()
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length - 6; i++)
            {
                if (arr[i] == 32656 &&
                    arr[i + 1] == 19759 &&
                    arr[i + 2] == 32763 &&
                    arr[i + 3] == 0 &&
                    arr[i + 5] == 0)
                {
                    int messegeCount = arr[i + 4];
                    i += 6;
                    for (int j = i; j < i + messegeCount; j++)
                    {
                        Console.Write((char)arr[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
