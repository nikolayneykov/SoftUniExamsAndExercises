using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();
            double[] numbersInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbersInput[i]))
                {
                    numbersCount.Add(numbersInput[i], 0);
                }
                numbersCount[numbersInput[i]]++;
            }

            foreach (KeyValuePair<double, int> number in numbersCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
