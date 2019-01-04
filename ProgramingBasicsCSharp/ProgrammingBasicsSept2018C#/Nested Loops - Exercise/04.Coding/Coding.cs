using System;

class Coding
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            int code = number % 10;
            char symbol = Convert.ToChar(code + 33);
            Console.WriteLine(code > 0 ? new string(symbol, code) : "ZERO");
            number /= 10;
        }
    }
}

