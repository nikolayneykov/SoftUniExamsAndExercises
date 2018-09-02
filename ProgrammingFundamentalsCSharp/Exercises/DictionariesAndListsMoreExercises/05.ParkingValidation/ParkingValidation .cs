using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registrations =
                new Dictionary<string, string>();
            Regex licensePlateRegex = new Regex(@"^[A-Z]{2}\d{4}[A-Z]{2}$");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string action = tokens[0];
                string username = tokens[1];

                if (action == "register")
                {
                    string licensePlateNumber = tokens[2];

                    if (registrations.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registrations[username]}");
                    }
                    else if (!licensePlateRegex.IsMatch(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                    else if (registrations.Any(x => x.Value == licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    }
                    else if (!registrations.ContainsKey(username))
                    {
                        registrations.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (!registrations.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registrations.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                }
            }
            foreach (var registration in registrations)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}
