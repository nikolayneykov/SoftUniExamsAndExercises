using System;
using System.Text.RegularExpressions;

class PartyInvitation
{
    static void Main(string[] args)
    {
        double validPercent = 0;
        double invalidPercent = 0;
        int totalCount = 0;
        Regex reg = new Regex(@"^[a-zA-Z]+$");
        string name = string.Empty;
        while ((name = Console.ReadLine()) != "Statistic")
        {
            if (reg.IsMatch(name))
            {
                name = name[0].ToString().ToUpper() + name.Substring(1).ToLower();
                Console.WriteLine(name);
                validPercent++;
            }
            else
            {
                Console.WriteLine("Invalid name!");
                invalidPercent++;
            }
            totalCount++;
        }
        validPercent = validPercent / totalCount * 100.0;
        invalidPercent = invalidPercent / totalCount * 100.0;

        Console.WriteLine($"Valid names are {validPercent:F2}% from {totalCount} names." +
            $"\nInvalid names are {invalidPercent:F2}% from {totalCount} names.");
    }
}

