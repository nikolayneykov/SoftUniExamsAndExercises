using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split('-');
                string product = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);
                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, 0);
                }
                shop[product] = price;
            }

            Dictionary<string, Customer> customers =
                new Dictionary<string, Customer>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of clients")
            {
                string[] inputTokens = input.Split('-', ',');
                string customer = inputTokens[0];
                string product = inputTokens[1];
                int quantity = int.Parse(inputTokens[2]);
                if (shop.ContainsKey(product))
                {
                    if (!customers.ContainsKey(customer))
                    {
                        customers.Add(customer, new Customer());
                    }
                    customers[customer].BuyProducts(product, quantity, shop[product]);
                }
            }
            decimal totalBill = 0;
            foreach (var customer in customers.OrderBy(c=>c.Key))
            {
                Console.WriteLine(customer.Key);
                foreach (var product in customer.Value.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Value.Bill:F2}");
                totalBill += customer.Value.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
    class Customer
    {
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
        public Customer()
        {
            this.ShopList = new Dictionary<string, int>();
            this.Bill = 0;
        }
        public void BuyProducts(string product, int quantity,decimal price)
        {
            if (!this.ShopList.ContainsKey(product))
            {
                this.ShopList.Add(product, quantity);
            }
            else
            {
                this.ShopList[product] += quantity;
            }
            this.Bill += quantity * price;
        }
    }
}
