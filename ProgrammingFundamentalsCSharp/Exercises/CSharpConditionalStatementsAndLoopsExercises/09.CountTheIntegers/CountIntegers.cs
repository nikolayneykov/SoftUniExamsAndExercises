using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountIntegers
    {
        static void Main(string[] args)
        {
            int integerCounter = 0;
            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    integerCounter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(integerCounter);
            }
        }
    }
}
