using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Pyramidic
{
    class Pyramidic
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> inputLines = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                inputLines.Add(line);
            }
            FindBiggestPyramid(inputLines);
        }
        static void FindBiggestPyramid(List<string> inputLines)
        {
            char biggestPyramidSymbol = inputLines[0][0];
            int biggestPyramidRows = int.MinValue;

            for (int inputRow = 0; inputRow < inputLines.Count - 1; inputRow++)
            {
                string currentRow = inputLines[inputRow];
                char tempSymbol;
                for (int i = 0; i < currentRow.Length; i++)
                {
                    tempSymbol = currentRow[i];
                    int nextRowLength = 3;
                    int tempRows = 1;
                    for (int j = inputRow + 1; j < inputLines.Count; j++)
                    {
                        string nextRow = inputLines[j];
                        if (nextRow.Contains(new string(tempSymbol, nextRowLength)))
                        {
                            tempRows++;
                            nextRowLength += 2;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (biggestPyramidRows < tempRows)
                    {
                        biggestPyramidSymbol = tempSymbol;
                        biggestPyramidRows = tempRows;
                    }
                }
            }
            PrintPyramid(biggestPyramidSymbol, biggestPyramidRows);
        }
        static void PrintPyramid(char symbol, int rows)
        {
            int rowLength = 1;
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(symbol, rowLength));
                rowLength += 2;
            }
        }
    }
}
