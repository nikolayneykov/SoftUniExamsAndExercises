using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(' ', ',');
            string[] availableSongs = Console.ReadLine()
                .Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> participantData =
                new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] inputTokens = input
                    .Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries);
                string currentParticipant = inputTokens[0];
                string currentSong = inputTokens[1];
                string award = inputTokens[2];
                if (participants.Contains(currentParticipant) &&
                    availableSongs.Contains(currentSong))
                {
                    if (!participantData.ContainsKey(currentParticipant))
                    {
                        participantData.Add(currentParticipant, new List<string>());
                    }
                    if (!participantData[currentParticipant].Contains(award))
                    {
                        participantData[currentParticipant].Add(award);
                    }
                }
            }
            bool haveAwards = false;
            participantData = participantData
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, List<string>> participant in participantData)
            {
                string participantName = participant.Key;
                List<string> participantAwards = participant.Value.OrderBy(x=>x).ToList();
                int awardCount = participantAwards.Count;
                Console.WriteLine($"{participantName}: {awardCount} awards");
                foreach (string award in participantAwards)
                {
                    Console.WriteLine($"--{award}");
                    haveAwards = true;
                }
            }
            if (!haveAwards)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
