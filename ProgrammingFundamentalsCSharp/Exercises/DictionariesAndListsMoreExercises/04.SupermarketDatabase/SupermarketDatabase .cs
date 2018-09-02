using System;
using System.Collections.Generic;

namespace _04.SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> data =
                new Dictionary<string, double[]>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="stocked")
            {
                string[] tokens = input.Split();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);
                if (!data.ContainsKey(product))
                {
                    data.Add(product, new double[] { 0, 0 });
                }
                data[product][0] = price;
                data[product][1] += quantity;
            }
            double grandTotal = 0;
            foreach (var product in data)
            {
                string productName = product.Key;
                double price = product.Value[0];
                double quantity = product.Value[1];
                double total = price * quantity;
                Console.WriteLine($"{productName}: ${price:F2} * {quantity} = ${total:F2}");
                grandTotal += total;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
