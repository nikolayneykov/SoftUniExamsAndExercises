using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<DNA> result = new List<DNA>();
            int sampleNumber = 1;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                input = input.Replace("!", "");
                int currentSum = 0;
                int longestSequenceLength = 0;
                int currentSequenceLength = 0;
                int currentStartIndex = input.Length - 1;
                bool inSequence = false;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] == '1')
                    {
                        currentSum++;
                        inSequence = true;
                    }
                    else
                    {
                        currentSequenceLength = 0;
                        inSequence = false;
                    }
                    if (inSequence)
                    {
                        currentSequenceLength++;
                        if (currentSequenceLength >= longestSequenceLength)
                        {
                            longestSequenceLength = currentSequenceLength;
                            currentStartIndex = i;
                        }
                    }
                }
                result.Add(new DNA(longestSequenceLength,
                    currentStartIndex,
                    currentSum,
                    sampleNumber,
                    input));
                sampleNumber++;
            }
            DNA bestSequence = result
                .OrderByDescending(x => x.LongestSequence)
                .ThenBy(x => x.StartingIndex)
                .ThenByDescending(x => x.Sum)
                .First();
            Console.WriteLine($"Best DNA sample {bestSequence.SampleNumber} with sum: {bestSequence.Sum}.");
            Console.WriteLine(string.Join(" ",bestSequence.DnaString.ToCharArray()));
        }
    }
    class DNA
    {
        public int LongestSequence { get; set; }
        public int StartingIndex { get; set; }
        public int Sum { get; set; }
        public int SampleNumber { get; set; }
        public string DnaString { get; set; }
        public DNA(int longestSequence, int startingIndex,
            int sum, int sampleNumber, string dnaString)
        {
            this.LongestSequence = longestSequence;
            this.StartingIndex = startingIndex;
            this.Sum = sum;
            this.SampleNumber = sampleNumber;
            this.DnaString = dnaString;
        }
    }
}
