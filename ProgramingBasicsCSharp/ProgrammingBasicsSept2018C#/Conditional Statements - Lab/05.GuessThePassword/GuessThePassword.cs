using System;

class GuessThePassword
{
    static void Main(string[] args)
    {
        string passwordInput = Console.ReadLine();
        Console.WriteLine(passwordInput == "s3cr3t!P@ssw0rd" ?
            "Welcome" : "Wrong password!");
    }
}

