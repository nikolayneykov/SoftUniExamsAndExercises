using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, List<string>>> requests =
                new Dictionary<string, Dictionary<string, List<string>>>();
            while ((input = Console.ReadLine()) != "Time for Code")
            {
                Regex requestPattern =
                    new Regex(@"^(?<id>\d+ )#(?<eventName>[^@]+)((?<participants>\@.*)+)?$");
                if (requestPattern.IsMatch(input))
                {
                    Match currentRequest = requestPattern
                        .Match(input);
                    string id = currentRequest
                        .Groups["id"]
                        .Value;
                    string eventName = currentRequest
                        .Groups["eventName"]
                        .Value
                        .Trim();
                    List<string> participants = currentRequest
                        .Groups["participants"]
                        .Value
                        .Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .Distinct()
                        .ToList();
                    if (requests.ContainsKey(id))
                    {
                        if (requests[id].ContainsKey(eventName))
                        {
                            foreach (string participant in participants)
                            {
                                if (!requests[id][eventName].Contains(participant))
                                {
                                    requests[id][eventName].Add(participant);
                                }
                            }
                        }
                    }
                    if (!requests.ContainsKey(id))
                    {
                        requests.Add(id, new Dictionary<string, List<string>>());
                        requests[id].Add(eventName, participants);
                    }
                }
            }
            Dictionary<string, List<string>> result =
                new Dictionary<string, List<string>>();
            foreach (var id in requests)
            {
                foreach (var eventName in id.Value)
                {
                    result.Add(eventName.Key, eventName.Value);
                }
            }
            result = result
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, List<string>> eventName in result)
            {
                Console.WriteLine($"{eventName.Key} - {eventName.Value.Count}");
                foreach (string participant in eventName.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
