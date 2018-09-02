using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data =
                new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache =
                new Dictionary<string, Dictionary<string, long>>();
            string inputLines = string.Empty;
            while ((inputLines = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] inputTokens = inputLines
                    .Split(new[] { ' ', '-', '>', '|' },
                    StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens.Length == 1)
                {
                    string dataSet = inputTokens[0];
                    data.Add(dataSet, new Dictionary<string, long>());
                }
                else
                {
                    string dataKey = inputTokens[0];
                    int dataSize = int.Parse(inputTokens[1]);
                    string dataSet = inputTokens[2];
                    if (!data.ContainsKey(dataSet))
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }
                        cache[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                }

                if (cache.Count > 0)
                {
                    List<string> dataSetsToClear = new List<string>();
                    foreach (KeyValuePair<string, Dictionary<string, long>> key in cache)
                    {
                        string dataSet = key.Key;
                        if (data.ContainsKey(dataSet))
                        {
                            foreach (KeyValuePair<string, long> keyAndSize in key.Value)
                            {
                                string dataKey = keyAndSize.Key;
                                long dataSize = keyAndSize.Value;
                                data[dataSet].Add(dataKey, dataSize);
                            }
                            dataSetsToClear.Add(dataSet);
                        }
                    }
                    for (int i = 0; i < dataSetsToClear.Count; i++)
                    {
                        cache.Remove(dataSetsToClear[i]);
                    }
                }
            }

            data = data
                .OrderByDescending(x => x.Value.Values.Sum())
                .Take(1)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, Dictionary<string, long>> dataSet in data)
            {
                Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.Values.Sum()}");
                foreach (KeyValuePair<string, long> keyAndSize in dataSet.Value)
                {
                    Console.WriteLine($"$.{keyAndSize.Key}");
                }
            }
        }
    }
}
