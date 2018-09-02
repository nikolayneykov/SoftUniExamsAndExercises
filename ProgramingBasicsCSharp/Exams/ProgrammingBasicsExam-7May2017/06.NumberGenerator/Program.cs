using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            bool reached = false;
            for (int i = m; i >= 1 && !reached; i--)
            {
                for (int j = n; j >= 1 && !reached; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        int mnl = int.Parse(i.ToString() + j.ToString() + k.ToString());

                        if (mnl % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (mnl % 10 == 5)
                        {
                            special -= 2;
                        }
                        else if (mnl % 2 == 0)
                        {
                            special *= 2;
                        }
                        if (special >= control)
                        {
                            reached = true;
                            break;
                        }
                    }
                }

            }
            if (reached)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
            }
            else
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }
        }
    }
}
