using System;
using System.Linq;

namespace _02.ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(array);
                        break;
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string replacement = command[2];
                        array[index] = replacement;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
