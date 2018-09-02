using System;

namespace _06.CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long max = 0;
            switch (numeralType)
            {
                case "sbyte": max = sbyte.MaxValue; break;
                case "int": max = int.MaxValue; break;
                case "long": max = long.MaxValue; break;
            }
            long result = long.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                if (number <= max)
                {
                    if (number>result)
                    {
                        result = number;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
