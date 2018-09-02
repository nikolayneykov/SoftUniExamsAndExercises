using System;

namespace _01.TypeBoundaries
{
    class TypeBoundaries
    {
        static void Main(string[] args)
        {
            long min = 0;
            long max = 0;
            string command = Console.ReadLine();
            switch (command)
            {
                case "sbyte": min = sbyte.MinValue; max = sbyte.MaxValue; break;
                case "byte": max = byte.MaxValue; break;
                case "int": min = int.MinValue; max = int.MaxValue; break;
                case "uint": max = uint.MaxValue; break;
                case "long": min = long.MinValue; max = long.MaxValue; break;
                case "ulong": max = long.MaxValue; break;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
