using System;
using System.Globalization;
using System.Linq;

namespace _06.ByteFlip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            char[] message = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length == 2)
                .Select(x => x = string.Join("", x.Reverse()))
                .Reverse()
                .Select(x => (char)Convert.ToInt32(x, 16))
                .ToArray();
            Console.WriteLine(string.Join("", message));
        }
    }
}
