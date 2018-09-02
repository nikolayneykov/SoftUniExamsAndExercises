using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string delimiter = Console.ReadLine();
            string[] result = input.Split(new string[] { delimiter },
                StringSplitOptions.None);
            Console.WriteLine("["+string.Join(", ",result)+"]");
        }
    }
}
