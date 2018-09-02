using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int skip = tokens[0];
            int take = tokens[1];
            List<string> result = new List<string>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '|' && input[i + 1] == '<')
                {
                    StringBuilder picture = new StringBuilder();
                    for (int j = i + 2 + skip; j < input.Length && j < i + 2 + skip + take; j++)
                    {
                        if (input[j] == '|' && input[j + 1] == '<')
                        {
                            break;
                        }
                        picture.Append(input[j]);
                    }
                    result.Add(picture.ToString());
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
