using System;

class ThreeEqualNumbers
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        Console.WriteLine((firstNum == secondNum && firstNum == thirdNum) ?
            "yes" : "no");
    }
}

