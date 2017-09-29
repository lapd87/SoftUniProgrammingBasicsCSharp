using System;



class ConcatenateData
{
    static void Main()
    {
        string first = Console.ReadLine();
        string last = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();
        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", first, last, age, town);
    }
}

