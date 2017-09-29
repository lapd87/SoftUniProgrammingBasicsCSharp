using System;

class PasswordGuess
{
    static void Main()
    {
        string inputPass = Console.ReadLine();

        string pass = "s3cr3t!P@ssw0rd";

        if (inputPass == pass)
        {
            Console.WriteLine("Welcome");

        }

        else Console.WriteLine("Wrong password!");


    }
}
