using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Trainlands
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> trainData =
                new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                string[] inputTokens = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
                string trainName = inputTokens[0];
                string separator = inputTokens[1];
                if (inputTokens.Length == 3 && separator.Equals("->"))
                {
                    if (!trainData.ContainsKey(trainName))
                    {
                        trainData.Add(trainName, new Dictionary<string, int>());
                    }
                    string otherTrainName = inputTokens[2];
                    foreach (KeyValuePair<string, int> wagon in trainData[otherTrainName])
                    {
                        string wagonName = wagon.Key;
                        int wagonPower = wagon.Value;
                        trainData[trainName].Add(wagonName, wagonPower);
                    }
                    trainData.Remove(otherTrainName);
                }
                else if (inputTokens.Length == 3 && separator.Equals("="))
                {
                    if (!trainData.ContainsKey(trainName))
                    {
                        trainData.Add(trainName, new Dictionary<string, int>());
                    }
                    trainData[trainName].Clear();
                    string otherTrainName = inputTokens[2];
                    foreach (KeyValuePair<string, int> wagon in trainData[otherTrainName])
                    {
                        string wagonName = wagon.Key;
                        int wagonPower = wagon.Value;
                        trainData[trainName].Add(wagonName, wagonPower);
                    }
                }
                else
                {
                    string wagonName = inputTokens[2];
                    int wagonPower = int.Parse(inputTokens[4]);
                    if (!trainData.ContainsKey(trainName))
                    {
                        trainData.Add(trainName, new Dictionary<string, int>());
                    }
                    trainData[trainName].Add(wagonName, wagonPower);
                }
            }
            trainData = trainData
                .OrderByDescending(t => t.Value.Values.Sum())
                .ThenBy(w => w.Value.Count)
                .ToDictionary(t => t.Key, t => t.Value
                   .OrderByDescending(w => w.Value)
                   .ToDictionary(w => w.Key, w => w.Value));
            foreach (KeyValuePair<string, Dictionary<string, int>> train in trainData)
            {
                string trainName = train.Key;
                Console.WriteLine($"Train: {trainName}");
                Dictionary<string, int> wagons = train.Value;
                foreach (KeyValuePair<string, int> wagon in wagons)
                {
                    string wagonName = wagon.Key;
                    int wagonPower = wagon.Value;
                    Console.WriteLine($"###{wagonName} - {wagonPower}");
                }
            }
        }
    }
}
