using System;

class NumberPyramid
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        int row = 0;
        while (count <= n)
        {
            for (int col = 0; count <= n && col <= row; col++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
            row++;
        }
    }
}

