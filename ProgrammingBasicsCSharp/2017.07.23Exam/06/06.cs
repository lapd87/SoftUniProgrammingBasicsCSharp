using System;

class Task06
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        char third = char.Parse(Console.ReadLine());
        char fourth = char.Parse(Console.ReadLine());
        int fifth = int.Parse(Console.ReadLine());

        int count = 0;

        for (char i = 'A'; i <= first; i++)
        {
            for (int j = 'a'; j <= second; j++)
            {
                for (int k = 'a'; k <= third; k++)
                {
                    for (int l = 'a'; l <= fourth; l++)
                    {
                        for (int m = 0; m <= fifth; m++)
                        {
                            count++;
                        }
                    }
                }
            }
        }

        Console.WriteLine(count-1);
    }
}
