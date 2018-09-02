using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordInPlural
{
    class PrintWordInPlural
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] ends = {"o","ch","s","sh","x","z" }; 

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length-1);
                word += "ies";
            }
            else if (ends.Any(x=>word.EndsWith(x)))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
