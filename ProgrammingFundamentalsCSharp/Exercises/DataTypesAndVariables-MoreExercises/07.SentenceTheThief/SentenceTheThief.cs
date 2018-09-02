using System;

namespace _07.SentenceTheThief
{
    class SentenceTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long max = 0;
            long min = 0;
            switch (numeralType)
            {
                case "sbyte": min = sbyte.MinValue; max = sbyte.MaxValue; break;
                case "int": min = int.MinValue; max = int.MaxValue; break;
                case "long": min = long.MinValue; max = long.MaxValue; break;
            }
            long id = long.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long currentId = long.Parse(Console.ReadLine());
                if (currentId >= min && currentId <= max)
                {
                    if (currentId > id)
                    {
                        id = currentId;
                    }
                }
            }
            decimal sentence = id < 0 ? Math.Abs(Math.Floor(id / 128m)) : Math.Ceiling(id / 127m);
            Console.WriteLine(sentence>1?
                $"Prisoner with id {id} is sentenced to {sentence} years":
                 $"Prisoner with id {id} is sentenced to {sentence} year");
        }
    }
}
