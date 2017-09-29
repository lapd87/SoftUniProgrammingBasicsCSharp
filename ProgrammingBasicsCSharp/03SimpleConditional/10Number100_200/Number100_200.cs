using System;

class Number100_200
{
    static void Main()
    {


        int a = int.Parse(Console.ReadLine());

        if (a > 200)
        {
            Console.WriteLine("Greater than 200");
        }

        else if (a<100)
        {
            Console.WriteLine("Less than 100");
        }
        else
        {
            Console.WriteLine("Between 100 and 200");
        }
    }
}
