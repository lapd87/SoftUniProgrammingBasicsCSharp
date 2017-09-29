using System;

class ToyShop
{
    static void Main()
    {

        double vacation = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int talkingDoll = int.Parse(Console.ReadLine());
        int teddyBear = int.Parse(Console.ReadLine());
        int minnions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double totalSum = puzzles * 2.6 + talkingDoll * 3 + teddyBear * 4.1 + minnions * 8.2 + trucks * 2;
        double totalToys = puzzles + talkingDoll + teddyBear + minnions + trucks;
        if (totalToys >= 50)
        {
            totalSum = 0.75 * totalSum * 0.9;
        }
        else totalSum = totalSum * 0.9;

        if (totalSum >= vacation)
        {
            Console.WriteLine("Yes! {0:0.00} lv left.", totalSum - vacation);

        }
        else
            Console.WriteLine("Not enough money! {0:0.00} lv needed.", vacation - totalSum);

    }
}
