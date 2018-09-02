using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            string inputLines = string.Empty;
            while ((inputLines = Console.ReadLine()) != "All ofboard!")
            {
                int currentWagonWeight = int.Parse(inputLines);
                wagons.Add(currentWagonWeight);
                int totalWagonsWeight = wagons.Sum();
                if (locomotivePower < totalWagonsWeight)
                {
                    int wagonsCount = wagons.Count;
                    int averageWagonWeight = totalWagonsWeight / wagonsCount;
                    int indexToRemove = FindWagonToRemove(wagons, averageWagonWeight);
                    wagons.RemoveAt(indexToRemove);
                }
            }
            wagons.Reverse();
            Console.WriteLine(string.Join(" ", wagons) + " " + locomotivePower);
        }
        static int FindWagonToRemove(List<int> wagons, int average)
        {
            int index = 0;
            int difference = int.MaxValue;

            for (int i = 0; i < wagons.Count; i++)
            {
                int tempDifference = Math.Abs(wagons[i] - average);
                if (difference > tempDifference)
                {
                    difference = tempDifference;
                    index = i;
                }
            }
            return index;
        }
    }
}
