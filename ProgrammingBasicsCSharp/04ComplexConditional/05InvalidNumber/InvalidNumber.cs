using System;

class InvalidNumber
{
    static void Main()
    {

        int a = int.Parse(Console.ReadLine());

        if ((a >= 100 && a <= 200) || a == 0)
        {
            return;
        }
        else
        {
            Console.WriteLine("invalid");

        }
    }
}
