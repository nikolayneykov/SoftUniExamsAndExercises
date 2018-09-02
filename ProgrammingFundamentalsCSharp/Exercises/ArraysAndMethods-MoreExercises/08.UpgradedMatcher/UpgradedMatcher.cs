using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
               .Split(new[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries);
            long[] quantities = Console.ReadLine()
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            decimal[] prices = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                decimal price = prices[i];
                long quantity = 0;
                if (i < quantities.Length)
                {
                    quantity = quantities[i];
                }

                products.Add(name, new Product(name, quantity, price));
            }
            string productBuyInfo = string.Empty;
            while ((productBuyInfo = Console.ReadLine()) != "done")
            {
                string[] productBuyTokens = productBuyInfo
                    .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string buyName = productBuyTokens[0];
                long buyQuantity = long.Parse(productBuyTokens[1]);
                if (products[buyName].Quantity < buyQuantity)
                {
                    Console.WriteLine($"We do not have enough {buyName}");
                }
                else
                {
                    products[buyName].Quantity -= buyQuantity;
                    decimal cost = products[buyName].Price * buyQuantity;
                    Console.WriteLine($"{buyName} x {buyQuantity} costs {cost:F2}");
                }
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }

        public Product(string name, long quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
