using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
             */
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char symbol = '\u00A9';
            Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", symbol);

        }
    }
}
