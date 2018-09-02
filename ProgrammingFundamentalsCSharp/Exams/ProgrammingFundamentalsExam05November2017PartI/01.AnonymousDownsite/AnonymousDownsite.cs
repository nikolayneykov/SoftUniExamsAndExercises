using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());
            BigInteger securityToken = BigInteger.Pow(securityKey,n);           
            List<string> websites = new List<string>();
            decimal totalLoss = 0;
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new[] { ' '},
                    StringSplitOptions.RemoveEmptyEntries);
                string siteName = tokens[0];
                websites.Add(siteName);
                decimal siteLoss = long.Parse(tokens[1]) * decimal.Parse(tokens[2]);
                totalLoss += siteLoss;
            }
            foreach (string site in websites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
