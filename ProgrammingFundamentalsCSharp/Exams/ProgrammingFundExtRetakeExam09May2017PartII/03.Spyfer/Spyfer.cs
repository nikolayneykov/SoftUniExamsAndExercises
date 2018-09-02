using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Spyfer
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int index = 0;
            while (index < numbers.Count)
            {
                int currentElement = numbers[index];
                int leftElement = index - 1 >= 0 ? numbers[index - 1] : 0;
                int rightElement = index + 1 < numbers.Count ? numbers[index + 1] : 0;
                if (leftElement + rightElement == currentElement)
                {
                    if (index < numbers.Count - 1)
                    {
                        numbers.RemoveAt(index + 1);
                    }
                    if (index > 0)
                    {
                        numbers.RemoveAt(index - 1);
                    }
                    index = 0;
                    continue;
                }
                index++;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
