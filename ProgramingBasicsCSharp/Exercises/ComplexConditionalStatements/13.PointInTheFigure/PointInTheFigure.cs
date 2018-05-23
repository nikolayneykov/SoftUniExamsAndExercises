using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int blockSize = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((y > 0 && y < 4 * blockSize && x > blockSize && x < blockSize * 2) ||
                (y > 0 && y < blockSize && x > 0 && x < blockSize * 3))
            {
                Console.WriteLine("inside");
            }
            else if ((y == 0 && x >= 0 && x <= blockSize * 3) ||
                    (y == blockSize && ((x >= 0 && x <= blockSize) || (x >= blockSize * 2 && x <= blockSize * 3))) ||
                    (y == blockSize * 4 && x >= blockSize && x <= blockSize * 2) ||
                    ((x == 0 || x == blockSize * 3) && y >= 0 && y <= blockSize)||
                    (x==blockSize || x==blockSize*2)&&y>=blockSize && y<=blockSize*4)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
