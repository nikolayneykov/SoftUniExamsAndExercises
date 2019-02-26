using System;

class RhombusOfStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        PrintRhombus(n);
    }

    static void PrintRhombus(int n)
    {
        for (int row = n; row >= 1; row--)
        {
            PrintRow(row, n);
        }

        for (int row = 2; row <= n; row++)
        {
            PrintRow(row, n);
        }
    }

    static void PrintRow(int row, int n)
    {
        for (int col = 1; col <= n; col++)
        {
            if (col < row)
            {
                Console.Write(' ');
            }
            else
            {
                Console.Write("* ");
            }
        }

        Console.WriteLine();
    }
}

