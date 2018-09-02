using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            field = FillLadybugs(field);


            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandTokens = commands.Split(' ');
                int index = int.Parse(commandTokens[0]);
                string direction = commandTokens[1];
                int flyLength = int.Parse(commandTokens[2]);
                bool validIndex = index >= 0 && index < field.Length;
                bool hasLadybug = false;
                if (validIndex)
                {
                    hasLadybug = field[index] == 1;
                }
                if (hasLadybug)
                {
                    field[index] = 0;
                    if (direction.Equals("right"))
                    {
                        int nextIndex = index + flyLength;
                        while (nextIndex < field.Length)
                        {
                            if (field[nextIndex]==0)
                            {
                                field[nextIndex] = 1;
                                break;
                            }
                            nextIndex += flyLength;
                        }
                    }
                    else if (direction.Equals("left"))
                    {
                        int nextIndex = index - flyLength;
                        while (nextIndex>=0)
                        {
                            if (field[nextIndex]==0)
                            {
                                field[nextIndex] = 1;
                                break;
                            }
                            nextIndex -= flyLength;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ",field));
        }
        static int[] FillLadybugs(int[] field)
        {
            int[] bugIndexes = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();
            for (int i = 0; i < bugIndexes.Length; i++)
            {
                if (bugIndexes[i] >= 0 && bugIndexes[i] < field.Length)
                {
                    field[bugIndexes[i]] = 1;
                }
            }
            return field;
        }
    }
}
