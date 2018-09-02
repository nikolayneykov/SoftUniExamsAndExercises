using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            char[] intialInput = Console.ReadLine().ToCharArray();
            int[] numbers = intialInput
                .Where(x => char.IsDigit(x))
                .Select(x => x - '0')
                .ToArray();
            int[] take = numbers
                .Where((x, i) => i % 2 == 0)
                .ToArray();
            int[] skip = numbers
                .Where((x, i) => i % 2 == 1)
                .ToArray();
            string nonDigits = string.Join("", intialInput
                .Where(x => !char.IsDigit(x)));


            StringBuilder decryptedMessage = new StringBuilder();
            for (int i = 0, skipTotal = 0; i < skip.Length; i++)
            {
                decryptedMessage.Append(string.Concat(nonDigits.Skip(skipTotal).Take(take[i])));
                skipTotal += take[i] + skip[i];
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
