using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StringCommander
{
    class StringCommander
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> textToManipulate = input.ToList();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandTokens = input.Split(' ');
                string command = commandTokens[0];
                switch (command)
                {
                    case "Right":
                        int timesToRollRight = int.Parse(commandTokens[1]);
                        textToManipulate = RollRight(textToManipulate, timesToRollRight);
                        break;
                    case "Left":
                        int timesToRollLeft = int.Parse(commandTokens[1]);
                        textToManipulate = RollLeft(textToManipulate, timesToRollLeft);
                        break;
                    case "Insert":
                        int index = int.Parse(commandTokens[1]);
                        List<char> textToInsert = commandTokens[2].ToList();
                        textToManipulate.InsertRange(index, textToInsert);
                        break;
                    case "Delete":
                        int startIndex = int.Parse(commandTokens[1]);
                        int count = int.Parse(commandTokens[2]) - int.Parse(commandTokens[1]) + 1;
                        textToManipulate.RemoveRange(startIndex, count);
                        break;
                }
            }
            Console.WriteLine(string.Join("", textToManipulate));
        }
        static List<char> RollLeft(List<char> textToManpulate, int timesToRoll)
        {
            while (timesToRoll > 0)
            {
                char temp = textToManpulate[0];
                textToManpulate.RemoveAt(0);
                textToManpulate.Add(temp);
                timesToRoll--;
            }
            return textToManpulate;
        }
        static List<char> RollRight(List<char> textToManpulate, int timesToRoll)
        {
            while (timesToRoll > 0)
            {
                char temp = textToManpulate[textToManpulate.Count - 1];
                textToManpulate.RemoveAt(textToManpulate.Count - 1);
                textToManpulate.Insert(0, temp);
                timesToRoll--;
            }
            return textToManpulate;
        }
    }
}
