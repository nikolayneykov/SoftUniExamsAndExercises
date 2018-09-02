using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06_ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int move = 0;
            int score = 0;

            for (int i = 1; i <= n && score < control; i++)
            {
                for (int j = m; j >= 1 && score < control; j--)
                {
                    move++;
                    score += i * 2 + j * 3;
                }
            }

            if (score < control)
            {
                Console.WriteLine("{0} moves",move);
            }
            else
            {
                Console.WriteLine("{0} moves", move);
                Console.WriteLine("Score: {0} >= {1}",score,control);
            }
        }
    }
}
