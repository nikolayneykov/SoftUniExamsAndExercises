using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string core = string.Empty;
                string border = string.Empty;
                int borderLength = 1;
                bool isNilapdrome = false;
                while (borderLength <= input.Length / 2)
                {
                    string tempLeftBorder = input.Substring(0, borderLength);
                    string tempRightBorder = input.Substring(input.Length - borderLength);
                    if (tempLeftBorder == tempRightBorder)
                    {
                        border = tempRightBorder;
                        int coreLength = input.Length - borderLength * 2;
                        if (coreLength > 0)
                        {
                            core = input.Substring(borderLength, coreLength);
                            isNilapdrome = true;
                        }
                    }
                    borderLength++;
                }
                string result = core + border + core;
                if (isNilapdrome)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
