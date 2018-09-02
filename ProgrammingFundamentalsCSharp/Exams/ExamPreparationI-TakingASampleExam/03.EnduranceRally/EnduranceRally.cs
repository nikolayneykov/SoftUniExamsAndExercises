using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine().Split(' ');
            double[] track = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            for (int i = 0; i < participants.Length; i++)
            {
                string currentParticipant = participants[i];
                double currentParticipantFuel = currentParticipant.First();
                bool isFinished = true;
                for (int j = 0; j < track.Length; j++)
                {
                    double currentTrackFuel = track[j];
                    if (checkpoints.Contains(j))
                    {
                        currentParticipantFuel += currentTrackFuel;
                    }
                    else
                    {
                        currentParticipantFuel -= currentTrackFuel;
                        if (currentParticipantFuel<=0)
                        {
                            Console.WriteLine($"{currentParticipant} - reached {j}");
                            isFinished = false;
                            break;
                        }
                    }
                }
                if (isFinished)
                {
                    Console.WriteLine($"{currentParticipant} - fuel left {currentParticipantFuel:F2}");
                }
            }           
        }
    }
}