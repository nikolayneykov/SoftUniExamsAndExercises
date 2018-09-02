using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            decimal priceOfLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());

            priceOfLightsabers *= Math.Ceiling(countOfStudents + countOfStudents * 0.1M);
            priceOfRobes *= countOfStudents;
            priceOfBelts *= countOfStudents - countOfStudents / 6;
            decimal totalPrice = priceOfLightsabers + priceOfRobes + priceOfBelts;
            decimal diff = Math.Abs(amountOfMoney - totalPrice);
            Console.WriteLine(amountOfMoney >= totalPrice ?
                $"The money is enough - it would cost {totalPrice:F2}lv." :
                $"Ivan Cho will need {diff:F2}lv more.");
        }
    }
}
