using System;

namespace _06.NumberInRange1To100
{
    class NumberInRange1To100
    {
        static void Main(string[] args)
        {
            int numberToPrint = int.Parse(Console.ReadLine());

            while (numberToPrint<1 || numberToPrint>100)
            {
                Console.WriteLine("Еnter a number in the range [1...100]:");
                numberToPrint = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {numberToPrint}");
        }
    }
}
