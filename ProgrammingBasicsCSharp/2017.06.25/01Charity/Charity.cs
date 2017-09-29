using System;

class Charity
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int chefs = int.Parse(Console.ReadLine());
        int cakes = int.Parse(Console.ReadLine());
        int waffles = int.Parse(Console.ReadLine());
        int pancakes = int.Parse(Console.ReadLine());

        decimal cakesMoney = days * chefs * cakes * 45m;
        decimal wafflesMoney = days * chefs * waffles * 5.8m;
        decimal pancakesMoney = days * chefs * pancakes * 3.2m;

        decimal totalMoney = cakesMoney + wafflesMoney + pancakesMoney;
        decimal charityMoney = totalMoney - totalMoney / 8m;

        Console.WriteLine("{0:0.00}", charityMoney);
    }
}
