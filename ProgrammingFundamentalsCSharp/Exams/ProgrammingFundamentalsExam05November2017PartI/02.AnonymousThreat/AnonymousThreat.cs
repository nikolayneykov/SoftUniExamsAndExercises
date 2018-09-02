using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commandTokens = input.Split(' ');
                string command = commandTokens[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(commandTokens[1]);
                    startIndex = FixIndex(startIndex, data.Count - 1);
                    int endIndex = int.Parse(commandTokens[2]);
                    endIndex = FixIndex(endIndex, data.Count - 1);
                    data = Merge(data, startIndex, endIndex);

                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandTokens[1]);
                    index = FixIndex(index, data.Count - 1);
                    int partitions = int.Parse(commandTokens[2]);
                    data = Divide(data, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }
        static List<string> Divide(List<string> data, int index, int partitions)
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                if (i == index)
                {               
                    int partSize = data[i].Length / partitions;
                    for (int j = 0; j < data[i].Length; j += partSize)
                    {
                        if (partitions == 1)
                        {
                            newList.Add(data[i].Substring(j));
                            break;
                        }
                        newList.Add(data[i].Substring(j, partSize));
                        partitions--;
                    }
                }
                else
                {
                    newList.Add(data[i]);
                }
            }
            return newList;
        }
        static List<string> Merge(List<string> data, int startIndex, int endIndex)
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                if (i > startIndex && i <= endIndex)
                {
                    newList[startIndex] += data[i];
                }
                else
                {
                    newList.Add(data[i]);
                }
            }
            return newList;
        }
        static int FixIndex(int index, int maxIndex)
        {
            if (index < 0)
            {
                return 0;
            }
            else if (index > maxIndex)
            {
                return maxIndex;
            }
            return index;
        }
    }
}
