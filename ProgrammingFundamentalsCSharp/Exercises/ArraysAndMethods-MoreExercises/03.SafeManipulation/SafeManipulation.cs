using System;
using System.Linq;
namespace _03.SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string command = string.Empty;
            while ((command=Console.ReadLine())!="END")
            {
                string[] commandTokens = command.Split();
                switch (commandTokens[0])
                {
                    case "Reverse":
                        Array.Reverse(array);
                        break;
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(commandTokens[1]);
                        string replacement = commandTokens[2];
                        if (index < 0 || index > array.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            array[index] = replacement;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
