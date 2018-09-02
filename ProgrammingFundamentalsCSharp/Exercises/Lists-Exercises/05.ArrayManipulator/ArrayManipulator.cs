using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "print")
            {
                string[] commandTokens = commandInput.Split();
                string command = commandTokens[0];
                switch (command)
                {
                    case "add":
                        int indexToAdd = int.Parse(commandTokens[1]);
                        int elementToAdd = int.Parse(commandTokens[2]);
                        numbers.Insert(indexToAdd, elementToAdd);
                        break;
                    case "addMany":
                        int indexToAddMany = int.Parse(commandTokens[1]);
                        numbers.InsertRange(indexToAddMany, commandInput.Split().Skip(2).Select(int.Parse).ToList());
                        break;
                    case "contains":
                        int elementToContain = int.Parse(commandTokens[1]);
                        Console.WriteLine(numbers.IndexOf(elementToContain));
                        break;
                    case "remove":
                        int indexToRemove = int.Parse(commandTokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "shift":
                        int positionsToShift = int.Parse(commandTokens[1]) % numbers.Count;
                        int[] subArray = numbers.Take(positionsToShift).ToArray();
                        numbers.RemoveRange(0, positionsToShift);
                        numbers.AddRange(subArray);
                        break;
                    case "sumPairs":
                        for (int i = 0; i < numbers.Count-1; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
