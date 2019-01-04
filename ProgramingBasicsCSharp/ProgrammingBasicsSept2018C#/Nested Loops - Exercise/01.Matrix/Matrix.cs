using System;

class Matrix
{
    static void Main(string[] args)
    {
        int startAB = int.Parse(Console.ReadLine());
        int endAB = int.Parse(Console.ReadLine());
        int startCD = int.Parse(Console.ReadLine());
        int endCD = int.Parse(Console.ReadLine());

        for (int a = startAB; a <= endAB; a++)
            for (int b = startAB; b <= endAB; b++)
                for (int c = startCD; c <= endCD; c++)
                    for (int d = startCD; d <= endCD; d++)
                    {
                        if (a != b && c != d && (a + d) == (b + c))
                        {
                            Console.WriteLine($"{a}{b}\n{c}{d}\n");
                        }
                    }
    }
}

