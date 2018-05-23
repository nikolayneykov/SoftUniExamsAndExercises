using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if ((row == 0 || row==n-1)&&(col==0 ||col==n-1))
                    {
                        Console.Write("+ ");
                    }
                    else if ((row >0 || row < n - 1) && (col == 0 || col == n - 1))
                    {
                        Console.Write("| ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
