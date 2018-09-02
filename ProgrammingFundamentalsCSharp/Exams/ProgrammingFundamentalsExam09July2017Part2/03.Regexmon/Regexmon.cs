using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex didiReg = new Regex(@".*?([^A-Za-z-]+)");
            Regex bojoReg = new Regex(@".*?([a-zA-Z]+-[a-zA-Z]+)");
            while (true)
            {
                if (!didiReg.IsMatch(input))
                {
                    break;
                }
                Console.WriteLine(didiReg.Match(input).Groups[1].Value);
                input = didiReg.Replace(input, "", 1);
                if (!bojoReg.IsMatch(input))
                {
                    break;
                }
                Console.WriteLine(bojoReg.Match(input).Groups[1].Value);
                input=bojoReg.Replace(input,"",1);
            }
        }
    }
}
