using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "end")
            {
                string[] commandTokens = inputCommand.Split();
                string command = commandTokens[0];
                if (command == "exchange")
                {
                    int index = int.Parse(commandTokens[1]);
                    if (index >= 0 && index < array.Length)
                    {
                        array = ExchangeArray(array, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "max" || command == "min")
                {
                    string numberType = commandTokens[1];
                    PrintIndexOfMaxOrMinElement(array, command, numberType);
                }
                else if (command == "first" || command == "last")
                {
                    int count = int.Parse(commandTokens[1]);
                    if (count <= array.Length)
                    {
                        string numberType = commandTokens[2];
                        List<int> numbersToPrint = new List<int>();
                        if (numberType == "even")
                        {
                            if (command == "first")
                            {
                                numbersToPrint = array
                                    .Where(x => x % 2 == 0)
                                    .Take(count)
                                    .ToList();
                            }
                            else if (command == "last")
                            {
                                numbersToPrint = array
                                    .Where(x => x % 2 == 0)
                                    .Reverse()
                                    .Take(count)
                                    .Reverse()
                                    .ToList();
                            }
                        }
                        else if (numberType == "odd")
                        {

                            if (command == "first")
                            {
                                numbersToPrint = array
                                    .Where(x => x % 2 == 1)
                                    .Take(count)
                                    .ToList();
                            }
                            else if (command == "last")
                            {
                                numbersToPrint = array
                                    .Where(x => x % 2 == 1)
                                    .Reverse()
                                    .Take(count)
                                    .Reverse()
                                    .ToList();
                            }
                        }

                        if (numbersToPrint.Count != 0)
                        {
                            Console.WriteLine($"[{string.Join(", ", numbersToPrint)}]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        static void PrintIndexOfMaxOrMinElement(int[] arr, string command, string numberType)
        {
            int maxEven = int.MinValue;
            int maxEvenIndex = -1;
            int maxOdd = int.MinValue;
            int maxOddIndex = -1;
            int minEven = int.MaxValue;
            int minEvenIndex = -1;
            int minOdd = int.MaxValue;
            int minOddIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (maxEven <= arr[i])
                    {
                        maxEven = arr[i];
                        maxEvenIndex = i;
                    }
                    if (minEven >= arr[i])
                    {
                        minEven = arr[i];
                        minEvenIndex = i;
                    }
                }
                else
                {
                    if (maxOdd <= arr[i])
                    {
                        maxOdd = arr[i];
                        maxOddIndex = i;
                    }
                    if (minOdd >= arr[i])
                    {
                        minOdd = arr[i];
                        minOddIndex = i;
                    }
                }
            }
            switch (command)
            {
                case "max":
                    switch (numberType)
                    {
                        case "even":
                            Console.WriteLine(maxEvenIndex != -1 ? $"{maxEvenIndex}" : "No matches");
                            break;
                        case "odd":
                            Console.WriteLine(maxOddIndex != -1 ? $"{maxOddIndex}" : "No matches");
                            break;
                    }
                    break;
                case "min":
                    switch (numberType)
                    {
                        case "even":
                            Console.WriteLine(minEvenIndex != -1 ? $"{minEvenIndex}" : "No matches");
                            break;
                        case "odd":
                            Console.WriteLine(minOddIndex != -1 ? $"{minOddIndex}" : "No matches");
                            break;
                    }
                    break;
            }
        }
        static int[] ExchangeArray(int[] array, int index)
        {
            int[] exchangedArray = new int[array.Length];
            for (int i = 0, j = index + 1; i < exchangedArray.Length; i++, j++)
            {
                if (j == exchangedArray.Length)
                {
                    j = 0;
                }
                exchangedArray[i] = array[j];
            }
            return exchangedArray;
        }
    }
}
