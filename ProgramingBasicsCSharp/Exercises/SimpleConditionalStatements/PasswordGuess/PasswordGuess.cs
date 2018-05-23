using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();
            Console.WriteLine(passwordInput== "s3cr3t!P@ssw0rd"?
                "Welcome":"Wrong password!");
        }
    }
}
