using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class EmailStatistic
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder emails = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            emails.Append(Console.ReadLine());
            emails.Append(" ");
        }
        string mails = emails.ToString();
        string pattern = @"\b(?<users>[A-Za-z]{5,})@(?<domains>[a-z]{3,}\.(bg|com|org))\b";
        Regex regex = new Regex(pattern);
        MatchCollection matchedEmails = regex.Matches(mails);
        Dictionary<string, List<string>> emailData = new Dictionary<string, List<string>>();
        foreach (Match email in matchedEmails)
        {
            string domain = email.Groups["domains"].ToString();
            string user = email.Groups["users"].ToString();

            if (emailData.ContainsKey(domain) == false)
            {
                emailData.Add(domain, new List<string>());
            }
            if (emailData[domain].Contains(user) == false)
            {
                emailData[domain].Add(user);
            }
        }
        foreach (var domain in emailData.OrderByDescending(d => d.Value.Count()))

        {
            Console.WriteLine($"{domain.Key}:");
            foreach (var user in domain.Value)
            {
                Console.WriteLine($"### {user}");
            }
        }
    }
}
