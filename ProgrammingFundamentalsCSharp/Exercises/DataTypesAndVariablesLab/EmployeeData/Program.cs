using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nikolay";
            string lastName = "Neykov";
            byte age = 24;
            char gender = 'm';
            long personalIdNumber = 8306112507;
            int uniqueEmployeeNumber = 27569999;
            Console.WriteLine("First name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}" +
                "\nPersonal ID Number: {4}\nUnique Employee Number:{5}",
                firstName, lastName, age, gender, personalIdNumber, uniqueEmployeeNumber);
        }
    }
}
