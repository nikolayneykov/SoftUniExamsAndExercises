using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = Console.ReadLine();
            for (int i = 0; i < numberOfStrings-1; i++)
            {
                result += delimiter + Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
