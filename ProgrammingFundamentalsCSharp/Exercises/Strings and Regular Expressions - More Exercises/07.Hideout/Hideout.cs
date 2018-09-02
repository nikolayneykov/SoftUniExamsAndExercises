using System;

namespace _07.Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            while (true)
            {
                string[] hiddeoutTokens = Console.ReadLine().Split();
                string hideout = new string(char.Parse(hiddeoutTokens[0]), int.Parse(hiddeoutTokens[1]));
                if (map.Contains(hideout))
                {
                    int hideoutIndex = map.IndexOf(hideout);
                    int hideoutSize = hideout.Length;
                    int i = hideoutIndex + hideoutSize;
                    while (i < map.Length && map[i] == char.Parse(hiddeoutTokens[0]))
                    {
                        hideoutSize++;
                        i++;
                    }
                    Console.WriteLine($"Hideout found at index {hideoutIndex} and it is with size {hideoutSize}!");
                    break;
                }
            }
        }
    }
}
