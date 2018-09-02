using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string employeeName = Console.ReadLine();
            int employeeAge = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {employeeName}");
            Console.WriteLine($"Age: {employeeAge}");
            Console.WriteLine($"Employee ID: {employeeID:D8}");
            Console.WriteLine($"Salary: {employeeSalary:F2}");
        }
    }
}
