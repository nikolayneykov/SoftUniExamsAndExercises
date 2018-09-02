using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackIn30Minutes
{
    class HourAfter30Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute += 30;
            hour += minute / 60;
            hour %= 24;
            minute %= 60;
            Console.WriteLine($"{hour}:{minute:D2}");
        }
    }
}
