using System;

class MagicNumbers
{
    static void Main(string[] args)
    {
        int magicNum = int.Parse(Console.ReadLine());

        for (int i = 111111; i <= 999999; i++)
        {
            int currentMultiplication = 1;
            int currentCombination = i;
            while (currentCombination > 0)
            {
                currentMultiplication *= currentCombination % 10;
                currentCombination /= 10;
            }
            if (currentMultiplication == magicNum)
            {
                Console.Write(i + " ");
            }
        }
    }
}

