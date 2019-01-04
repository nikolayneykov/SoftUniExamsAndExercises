using System;

class Salary
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());

        for (int i = 0; salary > 0 && i < n; i++)
        {
            string website = Console.ReadLine();
            salary -= website == "Facebook" ? 150 :
                      website == "Instagram" ? 100 :
                      website == "Reddit" ? 50 : 0;
        }
        Console.WriteLine(salary > 0 ? salary.ToString() : "You have lost your salary.");
    }
}

