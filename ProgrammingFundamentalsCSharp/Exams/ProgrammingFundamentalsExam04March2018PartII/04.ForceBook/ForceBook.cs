using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceData =
                new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                Regex switchSide = new Regex(@"^(.+) -> (.+)$");
                Regex joinSide = new Regex(@"^(.+) \| (.+)$");
                string forceSide = string.Empty;
                string forceUser = string.Empty;
                if (switchSide.IsMatch(input))
                {
                    forceSide = switchSide.Match(input).Groups[2].Value;
                    forceUser = switchSide.Match(input).Groups[1].Value;
                    if (!forceData.ContainsKey(forceSide))
                    {
                        forceData.Add(forceSide, new List<string>());
                    }
                    string forceSideContainingUser = string.Empty;
                    foreach (KeyValuePair<string, List<string>> force in forceData)
                    {
                        if (force.Value.Contains(forceUser))
                        {
                            forceSideContainingUser = force.Key;
                            break;
                        }
                    }
                    if (forceSideContainingUser != string.Empty)
                    {
                        forceData[forceSideContainingUser].Remove(forceUser);
                    }
                    if (!forceData[forceSide].Contains(forceUser))
                    {
                        forceData[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
                else if (joinSide.IsMatch(input))
                {
                    forceSide = joinSide.Match(input).Groups[1].Value;
                    forceUser = joinSide.Match(input).Groups[2].Value;
                    if (!forceData.ContainsKey(forceSide))
                    {
                        forceData.Add(forceSide, new List<string>());
                    }
                    if (!forceData[forceSide].Contains(forceUser) &&
                        !forceData.Values.Any(x => x.Contains(forceUser)))
                    {
                        forceData[forceSide].Add(forceUser);
                    }
                }
            }
            forceData = forceData
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, List<string>> force in forceData)
            {
                string side = force.Key;
                int members = force.Value.Count;
                Console.WriteLine($"Side: {side}, Members: {members}");
                foreach (string member in force.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
