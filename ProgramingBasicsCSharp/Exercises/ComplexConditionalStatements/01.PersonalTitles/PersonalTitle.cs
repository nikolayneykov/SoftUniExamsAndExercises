using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitles
{
    class PersonalTitle
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string title = string.Empty;
            if (gender=='m')
            {
                title = age < 16 ? "Master" : "Mr.";
            }
            else
            {
                title = age < 16 ? "Miss" : "Ms.";
            }
            Console.WriteLine(title);
        }
    }
}
