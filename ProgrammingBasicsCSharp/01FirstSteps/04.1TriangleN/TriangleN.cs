using System;
class TriangleN
{
    static void Main()
    {
        Console.Write("enter total stars:");
        int n = int.Parse(Console.ReadLine());
        int sum = 1;
        for (int i = 1; i <= n && sum < n; i += 1)
            sum++
            Console.WriteLine(new string('*', i));
    }
}
