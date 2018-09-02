using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incom = double.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double excellentResultsScholarship = 0;

            if (avarageGrade >= 5.50)
            {
                excellentResultsScholarship = Math.Floor(avarageGrade * 25);
            }
            if (incom < minimumWage && avarageGrade > 4.5)
            {
                socialScholarship = Math.Floor(minimumWage * 0.35);
            }

            if (socialScholarship == 0 && excellentResultsScholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                Console.WriteLine(excellentResultsScholarship >= socialScholarship ?
                    "You get a scholarship for excellent results {0} BGN" :
                    "You get a Social scholarship {1} BGN",
                    excellentResultsScholarship, socialScholarship);
            }
        }
    }
}
