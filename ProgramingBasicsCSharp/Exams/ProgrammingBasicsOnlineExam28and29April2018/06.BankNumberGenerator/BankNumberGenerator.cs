using System;

namespace _06.BankNumberGenerator
{
    class BankNumberGenerator
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i1 = a; i1 <= 99; i1++)
            {
                for (int i2 = b; i2 <= 'Z'; i2++)
                {
                    for (int i3 = c; i3 <= 'z'; i3++)
                    {
                        for (int i4 = d; i4 <= 'Z'; i4++)
                        {
                            for (int i5 = e; i5 >=10; i5--)
                            {
                                if (i1 % 10 == 2 && i5 % 10 == 5)
                                {
                                    n--;

                                    if (n==0)
                                    {
                                        Console.WriteLine($"{i1}{(char)i2}{(char)i3}{(char)i4}{i5}");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
