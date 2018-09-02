using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int count = 0;
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    char currentChar = char.ToLower(encryptedMessage[j]);
                    if (currentChar == 's' || currentChar == 't' ||
                        currentChar == 'a' || currentChar == 'r')
                    {
                        count++;
                    }
                }

                string decryptedMessage = new string(
                    encryptedMessage
                    .ToCharArray()
                    .Select(x => (char)(x - count))
                    .ToArray());
                Regex reg = new Regex(@"@([a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!([AD])![^@\-!:>]*->[0-9]+");
                if (reg.IsMatch(decryptedMessage))
                {
                    string planetName = reg.Match(decryptedMessage).Groups[1].Value;
                    string attackType = reg.Match(decryptedMessage).Groups[2].Value;
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            int attackedPlanetsCount = attackedPlanets.Count;
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
            foreach (string planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            int destroyedPlanetsCount = destroyedPlanets.Count;
            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            foreach (string planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
