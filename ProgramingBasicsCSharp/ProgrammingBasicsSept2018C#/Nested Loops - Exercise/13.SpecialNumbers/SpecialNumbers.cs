using System;

class SpecialNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1111; i <= 9999; i++)
        {
            int firstDigit = i / 1000;
            int secondDigit = (i / 100) % 10;
            int thirdDigit = (i / 10) % 10;
            int fourthDigit = i % 10;
            bool isMagic = firstDigit != 0 && n % firstDigit == 0 &&
                           secondDigit != 0 && n % secondDigit == 0 &&
                           thirdDigit != 0 && n % thirdDigit == 0 &&
                           fourthDigit != 0 && n % fourthDigit == 0;
            if (isMagic)
            {
                Console.Write(i + " ");
            }
        }
    }
}

