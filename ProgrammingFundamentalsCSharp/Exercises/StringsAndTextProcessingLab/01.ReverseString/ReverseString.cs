using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string result = string.Join("", Console.ReadLine().ToCharArray().Reverse());
            Console.WriteLine(result);
        }
    }
}
