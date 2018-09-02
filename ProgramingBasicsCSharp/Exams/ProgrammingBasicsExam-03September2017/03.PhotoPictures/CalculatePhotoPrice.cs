using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhotoPictures
{
    class CalculatePhotoPrice
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            string photoType = Console.ReadLine();
            string orderType = Console.ReadLine();
            double price = 0;

            if (photoType == "9X13")
            {
                price = photoNumber >= 50 ?
                    (photoNumber * 0.16) - (photoNumber * 0.16 * 0.05) :
                    (photoNumber * 0.16);
            }
            else if (photoType == "10X15")
            {
                price = photoNumber >= 80 ?
                    (photoNumber * 0.16) - (photoNumber * 0.16 * 0.03) :
                    (photoNumber * 0.16);
            }
            else if (photoType == "13X18")
            {
                if (photoNumber >= 50 && photoNumber <= 100)
                {
                    price = (photoNumber * 0.38) - (photoNumber * 0.38 * 0.03);
                }
                else if (photoNumber > 100)
                {
                    price = (photoNumber * 0.38) - (photoNumber * 0.38 * 0.05);
                }
                else
                {
                    price = (photoNumber * 0.38);
                }
            }
            else if (photoType == "20X30")
            {
                if (photoNumber >= 10 && photoNumber <= 50)
                {
                    price = (photoNumber * 2.90) - (photoNumber * 2.90 * 0.07);
                }
                else if (photoNumber > 50)
                {
                    price = (photoNumber * 2.90) - (photoNumber * 2.90 * 0.09);
                }
                else
                {
                    price = (photoNumber * 0.38);
                }
            }
            price = orderType == "online" ? (price - price * 0.02) : (price);
            Console.WriteLine($"{price:F2}BGN");
        }
    }
}
