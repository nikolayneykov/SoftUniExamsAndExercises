using System;

class StupidPasswordGenerator
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i1 = 1; i1 <= n; i1++)
            for (int i2 = 1; i2 <= n; i2++)
                for (int i3 = 'a'; i3 < 'a' + l; i3++)
                    for (int i4 = 'a'; i4 < 'a' + l; i4++)
                        for (int i5 = 1; i5 <= n; i5++)
                        {
                            if (i5 > i1 && i5 > i2)
                            {
                                Console.Write($"{i1}{i2}{(char)i3}{(char)i4}{i5} ");
                            }
                        }
    }
}

