using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split();
            string inputCommands = string.Empty;

            while ((inputCommands = Console.ReadLine()) != "end")
            {
                string[] commandTokens = inputCommands.Split();
                bool isValidParameters = false;
                switch (commandTokens[0])
                {
                    case "reverse":
                        int startReverse = int.Parse(commandTokens[2]);
                        int countReverse = int.Parse(commandTokens[4]);
                        if (startReverse >= 0 && startReverse < data.Length &&
                            countReverse >= 0 && (startReverse + countReverse <= data.Length))
                        {
                            Array.Reverse(data, startReverse, countReverse);
                            isValidParameters = true;
                        }
                        break;
                    case "sort":
                        int startSort = int.Parse(commandTokens[2]);
                        int countSort = int.Parse(commandTokens[4]);
                        if (startSort >= 0 && startSort < data.Length &&
                            countSort >= 0 && (startSort + countSort <= data.Length))
                        {
                            Array.Sort(data, startSort, countSort);
                            isValidParameters = true;
                        }
                        break;
                    case "rollLeft":
                        int rollLeftCount = int.Parse(commandTokens[1]);
                        if (rollLeftCount >= 0)
                        {
                            for (int i = 0; i < rollLeftCount % data.Length; i++)
                            {
                                string firstElement = data[0];
                                for (int j = 0; j < data.Length - 1; j++)
                                {
                                    data[j] = data[j + 1];
                                }
                                data[data.Length - 1] = firstElement;
                            }
                            isValidParameters = true;
                        }
                        break;
                    case "rollRight":
                        int rollRightCount = int.Parse(commandTokens[1]);
                        if (rollRightCount >= 0)
                        {
                            for (int i = 0; i < rollRightCount % data.Length; i++)
                            {
                                string lastElement = data[data.Length - 1];
                                for (int j = data.Length - 1; j > 0; j--)
                                {
                                    data[j] = data[j - 1];
                                }
                                data[0] = lastElement;
                            }
                            isValidParameters = true;
                        }
                        break;
                }
                if (!isValidParameters)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
            Console.WriteLine("[" + (string.Join(", ", data)) + "]");
        }
    }
}
