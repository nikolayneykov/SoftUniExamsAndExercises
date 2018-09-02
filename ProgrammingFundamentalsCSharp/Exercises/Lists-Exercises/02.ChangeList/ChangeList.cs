using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();
            while (commands != "Odd" && commands != "Even")
            {
                string[] commandTokens = commands.Split();
                string currentComand = commandTokens[0];
                int element = int.Parse(commandTokens[1]);
                switch (currentComand)
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == element);
                        break;
                    case "Insert":
                        int index = int.Parse(commandTokens[2]);
                        numbers.Insert(index, element);
                        break;
                }
                commands = Console.ReadLine();
            }
            switch (commands)
            {
                case "Odd": Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1))); break;
                case "Even": Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0))); break;
            }
        }
    }
}
