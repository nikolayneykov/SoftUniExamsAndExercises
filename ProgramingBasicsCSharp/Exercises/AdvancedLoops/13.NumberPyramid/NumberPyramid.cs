using System;

namespace _13.NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberToPrint = 1;
            int rowLength = 1;
            while (numberToPrint <= n)
            {
                for (int i = 0; i < rowLength && numberToPrint <= n; i++)
                {
                    Console.Write(numberToPrint + " ");
                    numberToPrint++;
                }
                Console.WriteLine();
                rowLength++;
            }
        }
    }
}
