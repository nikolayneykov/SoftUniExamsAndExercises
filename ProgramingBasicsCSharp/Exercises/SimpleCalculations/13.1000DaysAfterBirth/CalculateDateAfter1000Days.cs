using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _13._1000DaysAfterBirth
{
    class CalculateDateAfter1000Days
    {
        static void Main(string[] args)
        {
            string dateInput = Console.ReadLine();
            DateTime dateToday = DateTime.ParseExact(dateInput,"dd-MM-yyyy",CultureInfo.InvariantCulture);
            dateToday = dateToday.AddDays(999);
            string dateAfter = dateToday.ToString("dd-MM-yyyy");
            Console.WriteLine(dateAfter);
        }
    }
}
