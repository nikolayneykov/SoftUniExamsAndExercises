using System;
using System.Linq;
using System.Text;

namespace _04.MorseCodeUpgraded
{
    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            string[] encryptedMessage = Console.ReadLine().Split('|');
            StringBuilder decryptedMessage = new StringBuilder();
            foreach (string encryptedLetter in encryptedMessage)
            {
                int asciiCode = 0;
                for (int i = 0; i < encryptedLetter.Length; i++)
                {
                    char symbol = encryptedLetter[i];
                    if (symbol == '0')
                    {
                        asciiCode += 3;
                    }
                    else if (symbol == '1')
                    {
                        asciiCode += 5;
                    }
                }
                int repeatedOneCount = string.Join("", encryptedLetter.Split('0').Where(x => x.Length > 1)).Length;
                int repeatedZeroCount = string.Join("", encryptedLetter.Split('1').Where(x => x.Length > 1)).Length;
                asciiCode += repeatedOneCount + repeatedZeroCount;
                decryptedMessage.Append((char)asciiCode);
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
