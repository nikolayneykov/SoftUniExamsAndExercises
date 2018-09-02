using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Trainers
    {
        static void Main(string[] args)
        {
            int numberfParticipants = int.Parse(Console.ReadLine());
            StringBuilder winningTeam = new StringBuilder();
            decimal technicalTrainersMoney= 0M;
            decimal theoreticalTrainersMoney = 0M;
            decimal practicalTrainersMoney= 0M;
            for (int i = 0; i < numberfParticipants; i++)
            {
                long distanceInMeters = long.Parse(Console.ReadLine()) * 1600;
                decimal cargoInKillograms = decimal.Parse(Console.ReadLine()) * 1000M;
                string teamName = Console.ReadLine();
                decimal participantEarnedMoney = (cargoInKillograms * 1.5M) - (0.7M * distanceInMeters * 2.5M);
                switch (teamName)
                {
                    case "Technical":technicalTrainersMoney += participantEarnedMoney; break;        
                    case "Theoretical": theoreticalTrainersMoney += participantEarnedMoney; break;        
                    case "Practical": practicalTrainersMoney += participantEarnedMoney; break;
                }         
            }
            if (technicalTrainersMoney>theoreticalTrainersMoney &&
                technicalTrainersMoney>practicalTrainersMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${technicalTrainersMoney:F3}.");
            }
            else if (theoreticalTrainersMoney>technicalTrainersMoney&&
                     theoreticalTrainersMoney>practicalTrainersMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoreticalTrainersMoney:F3}.");
            }
            else
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalTrainersMoney:F3}.");
            }
        }
    }
}
