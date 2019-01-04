using System;

class MultiplyTable
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int thirdDigit = number[2] - '0';
        int secondDigit = number[1] - '0';
        int firstDigit = number[0] - '0';

        for (int i1 = 1; i1 <= thirdDigit; i1++)
            for (int i2 = 1; i2 <= secondDigit; i2++)
                for (int i3 = 1; i3 <= firstDigit; i3++)
                {
                    int multiplication = i1 * i2 * i3;
                    Console.WriteLine($"{i1} * {i2} * {i3} = {multiplication};");
                }
    }
}

