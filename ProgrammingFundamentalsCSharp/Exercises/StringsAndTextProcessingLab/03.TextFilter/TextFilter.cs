using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] banlist = Console.ReadLine().Split(new string[] { ", "},
                StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (string word in banlist)
            {
               text= text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);                
        }
    }
}
