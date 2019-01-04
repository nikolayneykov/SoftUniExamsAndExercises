using System;

namespace _03.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            double valueIn = double.Parse(Console.ReadLine());
            string currencyIn = Console.ReadLine();
            string currencyOut = Console.ReadLine();

            double valueBGN = 0;
            switch (currencyIn)
            {
                case "BGN": valueBGN = valueIn; break;
                case "USD": valueBGN = valueIn * 1.79549; break;
                case "EUR": valueBGN = valueIn * 1.95583; break;
                case "GBP": valueBGN = valueIn * 2.53405; break;
            }

            double valueOut = 0;
            switch (currencyOut)
            {
                case "BGN": valueOut = valueBGN; break;
                case "USD": valueOut = valueBGN / 1.79549; break;
                case "EUR": valueOut = valueBGN / 1.95583; break;
                case "GBP": valueOut = valueBGN / 2.53405; break;
            }
            Console.WriteLine($"{valueOut:F2} {currencyOut}");
        }
    }
}
