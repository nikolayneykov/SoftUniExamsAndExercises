using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindTheLetter
{
    class FindTheLetter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split();
            string search = tokens[0];
            int n = int.Parse(tokens[1]);
            int index = input.IndexOf(search);
            while (index != -1)
            {
                n--;
                if (n == 0)
                {
                    break;
                }
                index = input.IndexOf(search, index + 1);
            }
            Console.WriteLine(index == -1 ?
                "Find the letter yourself!" :
                index.ToString());
        }
    }
}
