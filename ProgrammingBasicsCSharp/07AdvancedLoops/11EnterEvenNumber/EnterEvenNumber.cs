using System;

class EnterEvenNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n;

        There:

        if (int.TryParse(input, out n))
        {

            if (n % 2 != 0)
            {
                Console.WriteLine("Number is not even.");
                Console.Write("Enter even number: ");
                input = Console.ReadLine();
                goto There;
            }
            else
            {
                Console.WriteLine("Even number entered {0}", n);
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
            Console.Write("Enter even number: ");
            input = Console.ReadLine();
            goto There;
        }
    }
}
