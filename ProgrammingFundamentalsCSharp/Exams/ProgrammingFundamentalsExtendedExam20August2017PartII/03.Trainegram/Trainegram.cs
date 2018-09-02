using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Trainegram
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Traincode!")
            {
                Regex trainPattern = 
                    new Regex(@"^(<\[[^a-zA-Z0-9]*\]\.)(\.\[[a-zA-Z0-9]*\]\.)*$");
                if (trainPattern.IsMatch(input))
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
