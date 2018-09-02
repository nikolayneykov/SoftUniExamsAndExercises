using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());
            ulong bigger = Math.Max(num1, num2);
            ulong smaller = Math.Min(num1, num2);
            string biggerType = string.Empty;
            string smallerType = string.Empty;
            if (bigger >= byte.MinValue && bigger <= byte.MaxValue)
            {
                biggerType = "byte";
            }
            else if (bigger >=ushort.MinValue && bigger<=ushort.MaxValue)
            {
                biggerType = "ushort";
            }
            else if (bigger>=uint.MinValue && bigger<=uint.MaxValue)
            {
                biggerType = "uint";
            }
            else
            {
                biggerType = "ulong";
            }

            decimal overflowTimes = (decimal)bigger;
            if (smaller >= byte.MinValue && smaller <= byte.MaxValue)
            {
                smallerType = "byte";
                overflowTimes /= byte.MaxValue;
            }
            else if (smaller >= ushort.MinValue && smaller <= ushort.MaxValue)
            {
                smallerType = "ushort";
                overflowTimes /=  ushort.MaxValue;
            }
            else if (smaller >= uint.MinValue && smaller <= uint.MaxValue)
            {
                smallerType = "uint";
                overflowTimes /=  uint.MaxValue;
            }
            else
            {
                smallerType = "ulong";
                overflowTimes /=ulong.MaxValue;
            }
            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{bigger} can overflow {smallerType} {Math.Round(overflowTimes)} times");
        }
    }
}
