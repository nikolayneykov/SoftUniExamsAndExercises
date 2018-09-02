using System;

namespace _08.Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<' && input[i + 3] == '>')
                {
                    int explosionRadius = Math.Abs(input[i + 1] - input[i + 2]);
                    input[i] = '_';
                    input[i + 1] = '_';
                    input[i + 2] = '_';
                    input[i + 3] = '_';

                    int index = i - 1;
                    for (int j = index, k = explosionRadius; j >= 0 && k > 0; j--, k--)
                    {
                        input[j] = '_';
                    }
                    index = i + 4;
                    for (int j = index, k = explosionRadius; j < input.Length && k > 0; j++, k--)
                    {
                        input[j] = '_';
                    }
                }
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
