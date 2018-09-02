using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int asciiCode = int.Parse(Console.ReadLine());
                result += (char)asciiCode;
            }
            Console.WriteLine(result);
        }
    }
}
