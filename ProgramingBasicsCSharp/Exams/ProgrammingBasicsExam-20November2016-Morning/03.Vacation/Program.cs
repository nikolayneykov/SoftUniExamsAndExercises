using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int old = int.Parse(Console.ReadLine());
            int young = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double transportPrice = 0;
            switch (transport)
            {
                case "train": transportPrice = (old * 24.99 + young * 14.99)*2; break;
                case "bus": transportPrice = (old * 32.50 + young * 28.50)*2; break;
                case "boat": transportPrice = (old * 42.99 + young * 39.99)*2; break;
                case "airplane": transportPrice = (old * 70 + young * 50)*2; break;
            }

            if (transport == "train" && (old + young) >= 50)
            {
                transportPrice /= 2;
            }
            double hotelPrice = nights * 82.99;
            double totalPrice = ((transportPrice + hotelPrice) * 0.1) + transportPrice + hotelPrice;
            Console.WriteLine("{0:F2}",totalPrice);
        }
    }
}
