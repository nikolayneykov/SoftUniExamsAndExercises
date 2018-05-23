using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class PrintVowelsSum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':vowelsSum += 1;break;
                    case 'e':vowelsSum += 2;break;
                    case 'i':vowelsSum += 3;break;
                    case 'o':vowelsSum += 4;break;
                    case 'u':vowelsSum += 5;break;
                }
            }
            Console.WriteLine(vowelsSum);
        }
    }
}
