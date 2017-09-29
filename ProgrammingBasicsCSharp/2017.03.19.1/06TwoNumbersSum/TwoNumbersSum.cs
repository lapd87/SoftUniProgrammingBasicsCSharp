using System;

class TwoNumbersSum
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int combinations = 0;

        for (int i = firstNumber; i >= secondNumber; i--)
        {
            for (int j = firstNumber; j >= secondNumber; j--)
            {
                combinations++;

                if (i + j == magicNumber)
                {
                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinations, i, j, magicNumber);
                    return;
                }
            }
        }

        Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNumber);

    }
}
