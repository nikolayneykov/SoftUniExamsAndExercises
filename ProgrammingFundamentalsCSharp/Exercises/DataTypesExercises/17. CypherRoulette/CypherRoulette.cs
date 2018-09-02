using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            StringBuilder temp = new StringBuilder();
            bool appendFront = false;
            while (n > 0)
            {
                string command = Console.ReadLine();
                if (command == temp.ToString())
                {
                    result = string.Empty;
                    continue;
                }
                temp = new StringBuilder(command);
                if (command == "spin")
                {
                    if (appendFront == true)
                    {
                        appendFront = false;
                    }
                    else
                    {
                        appendFront = true;
                    }
                    continue;
                }
                result = appendFront ? command + result : result + command;
                n--;
            }
            Console.WriteLine(result);
        }
    }
}
