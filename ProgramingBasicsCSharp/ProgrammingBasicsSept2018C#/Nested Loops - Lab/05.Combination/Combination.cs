using System;

class Combination
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i1 = 0; i1 <= n; i1++)
            for (int i2 = 0; i2 <= n; i2++)
                for (int i3 = 0; i3 <= n; i3++)
                    for (int i4 = 0; i4 <= n; i4++)
                        for (int i5 = 0; i5 <= n; i5++)
                        {
                            if (i1 + i2 + i3 + i4 + i5 == n)
                            {
                                count++;
                            }
                        }
        Console.WriteLine(count);
    }
}

