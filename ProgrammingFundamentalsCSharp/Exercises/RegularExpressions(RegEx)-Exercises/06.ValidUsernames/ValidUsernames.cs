using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" /\\()".ToCharArray());
            Regex regUser = new Regex(@"^[a-zA-Z][a-zA-Z\d_]{2,24}$");
           
            int maxLengthSum = 0;
            List<string> validUserNames = new List<string>();
            foreach (string userName in input)
            {
                if (regUser.IsMatch(userName))
                {
                    validUserNames.Add(userName);                  
                }
            }
            string user1 = "";
            string user2 = "";
            for (int i = 0; i < validUserNames.Count-1; i++)
            {
                if (validUserNames[i].Length+validUserNames[i+1].Length>maxLengthSum)
                {
                    user1 = validUserNames[i];
                    user2 = validUserNames[i+1];
                    maxLengthSum = validUserNames[i].Length + validUserNames[i + 1].Length;
                }
            }
            Console.WriteLine(user1);
            Console.WriteLine(user2);
        }
    }
}
