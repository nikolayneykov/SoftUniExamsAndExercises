using System;

class TradeComissions
{
    static void Main(string[] args)
    {
        string city = Console.ReadLine();
        double sells = double.Parse(Console.ReadLine());
        double comissionPercent = 0;

        if (city == "Sofia")
        {
            if (sells >= 0 && sells <= 500)
            {
                comissionPercent = 0.05;
            }
            else if (sells > 500 && sells <= 1000)
            {
                comissionPercent = 0.07;
            }
            else if (sells > 1000 && sells <= 10000)
            {
                comissionPercent = 0.08;
            }
            else if (sells > 10000)
            {
                comissionPercent = 0.12;
            }
        }
        else if (city == "Varna")
        {
            if (sells >= 0 && sells <= 500)
            {
                comissionPercent = 0.045;
            }
            else if (sells > 500 && sells <= 1000)
            {
                comissionPercent = 0.075;
            }
            else if (sells > 1000 && sells <= 10000)
            {
                comissionPercent = 0.1;
            }
            else if (sells > 10000)
            {
                comissionPercent = 0.13;
            }
        }
        else if (city == "Plovdiv")
        {
            if (sells >= 0 && sells <= 500)
            {
                comissionPercent = 0.055;
            }
            else if (sells > 500 && sells <= 1000)
            {
                comissionPercent = 0.08;
            }
            else if (sells > 1000 && sells <= 10000)
            {
                comissionPercent = 0.12;
            }
            else if (sells > 10000)
            {
                comissionPercent = 0.145;
            }
        }

        double comissionValue = comissionPercent * sells;
        Console.WriteLine(comissionValue > 0 ? $"{comissionValue:F2}" : "error");
    }
}

