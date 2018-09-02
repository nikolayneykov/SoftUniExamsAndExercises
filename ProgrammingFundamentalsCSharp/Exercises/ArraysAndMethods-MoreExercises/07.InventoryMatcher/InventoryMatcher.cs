using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
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
                long quantity = quantities[i];
                decimal price = prices[i];
                products.Add(name, new Product(name, quantity, price));
            }
            string productNameToPrint = string.Empty;
            while ((productNameToPrint = Console.ReadLine()) != "done")
            {
                Console.WriteLine(products[productNameToPrint]);
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

        public override string ToString()
        {
            return $"{Name} costs: {Price}; Available quantity: {Quantity}";
        }
    }
}
