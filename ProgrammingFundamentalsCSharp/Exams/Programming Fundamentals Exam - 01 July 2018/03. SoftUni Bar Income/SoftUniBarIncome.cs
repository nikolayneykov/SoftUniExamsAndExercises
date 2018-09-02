using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
            decimal totalIncome = 0;
            Regex regex = new Regex(@"%([A-Z][a-z]+)%[^|%$.]*<(\w+)>[^|%$.]*\|(\d+)\|[^|%$.\d]*(\d+\.?\d+?)\$");
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    string customerName = regex.Match(input).Groups[1].Value;
                    string product = regex.Match(input).Groups[2].Value;
                    int count = int.Parse(regex.Match(input).Groups[3].Value);
                    decimal price = decimal.Parse(regex.Match(input).Groups[4].Value);
                    decimal totalPrice = count * price;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                    totalIncome += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
