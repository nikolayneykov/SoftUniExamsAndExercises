using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string[   ] input = Console.ReadLine()
                .Split(new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            List<Demon> demons = new List<Demon>();
            foreach (string demon in input)
            {
                string demonName = demon;
                int demonHealth = CalculateHealth(demon);
                double demonDamage = CalculateDamage(demon);
                demons.Add(new Demon(demonName, demonHealth, demonDamage));
            }
            demons = demons.OrderBy(x => x.Name).ToList();
            foreach (Demon currentDemon in demons)
            {
                string name = currentDemon.Name;
                int health = currentDemon.Health;
                double damage = currentDemon.Damage;
                Console.WriteLine($"{name} - {health} health, {damage:F2} damage");
            }
        }
        static double CalculateDamage(string demon)
        {
            double damage = 0;
            double multiplication = 1;
            double division = 1;
            Regex digitPattern = new Regex(@"([\+\-]*[0-9.]+[0-9]*)");
            MatchCollection digits = digitPattern.Matches(demon);
            foreach (var digit in digits)
            {
                damage += double.Parse(digit.ToString());
            }
            foreach (char symbol in demon)
            {
                switch (symbol)
                {
                    case '*': multiplication *= 2; break;
                    case '/': division *= 2; break;
                }
            }
            return damage * multiplication / division;
        }
        static int CalculateHealth(string demon)
        {
            Regex validSymbolPattern = new Regex(@"([^\d\.\+\-\*\/]+)");
            MatchCollection matches = validSymbolPattern.Matches(demon);
            int health = 0;
            foreach (var match in matches)
            {
                foreach (var symbol in match.ToString())
                {
                    health += symbol;
                }
            }
            return health;
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
        public Demon(string name, int health, double damage)
        { 
            Name = name;    
            Health = health;
            Damage = damage;
        }
    }
}

