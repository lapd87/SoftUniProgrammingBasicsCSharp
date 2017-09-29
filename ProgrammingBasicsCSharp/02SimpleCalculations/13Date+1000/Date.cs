using System;
using System.Globalization;

class Date
{
    static void Main()
    {
        string inputDate = Console.ReadLine();
        DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime newdate = date.AddDays(999);
        Console.WriteLine(newdate.ToString("dd-MM-yyyy"));

    }
}
