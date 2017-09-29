using System;

class EqualWords
{
    static void Main()
    {

        string input1 = Console.ReadLine().ToLower();
        string input2 = Console.ReadLine().ToLower();

        if (input1 == input2)
        {
            Console.WriteLine("yes");
        }
        else Console.WriteLine("no");

    }
}
