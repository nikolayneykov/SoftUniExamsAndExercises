using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            Regex surface = new Regex(@"^[^a-zA-Z0-9]+$");
            Regex mantle = new Regex(@"^[0-9_]+$");
            Regex mid = new Regex(@"^[^a-zA-Z0-9]+[0-9_]+([a-zA-Z]+)[0-9_]+[^a-zA-Z0-9]+$");
            string surfaceUp = Console.ReadLine();
            string mantleUp = Console.ReadLine();
            string middle = Console.ReadLine();
            string mantleDown = Console.ReadLine();
            string surfaceDown = Console.ReadLine();
            if (surface.IsMatch(surfaceUp) && surface.IsMatch(surfaceDown) &&
                mantle.IsMatch(mantleUp) && mantle.IsMatch(mantleUp) &&
                mid.IsMatch(middle))
            {
                int coreLength = mid.Match(middle).Groups[1].Value.Length;
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
