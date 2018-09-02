using System;
using System.Linq;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            string[] towns = sales.Select(x => x.Town).Distinct().OrderBy(x=>x).ToArray();
            foreach (string town in towns)
            {
                decimal totalSales = sales.Where(x => x.Town == town).Sum(x => x.Price * x.Quantity);
                Console.WriteLine($"{town} -> {totalSales:F2}");
            }

        }
        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                sales[i] = new Sale()
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])                  
                };
            }
            return sales;
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
