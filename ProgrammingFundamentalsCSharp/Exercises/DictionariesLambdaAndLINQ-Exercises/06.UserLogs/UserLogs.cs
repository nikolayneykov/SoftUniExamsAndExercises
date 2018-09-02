
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userLogs =
               new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string userName = tokens[2].Substring(5);
                string ip = tokens[0].Substring(3);
                if (!userLogs.ContainsKey(userName))
                {
                    userLogs.Add(userName, new Dictionary<string, int>());
                }
                if (!userLogs[userName].ContainsKey(ip))
                {
                    userLogs[userName].Add(ip, 0);
                }
                userLogs[userName][ip]++;
            }
            foreach (var userLog in userLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{userLog.Key}:");
                List<string> logs = new List<string>();
                foreach (var ip in userLog.Value)
                {
                    logs.Add($"{ip.Key} => {ip.Value}");
                }
                Console.WriteLine(string.Join(", ",logs)+".");
            }
        }
    }
}
