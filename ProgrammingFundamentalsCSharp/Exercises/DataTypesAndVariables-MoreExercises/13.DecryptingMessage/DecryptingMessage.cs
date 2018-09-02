using System;
using System.Text;

namespace _13.DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                decryptedMessage.Append((char)(char.Parse(Console.ReadLine())+key));
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
