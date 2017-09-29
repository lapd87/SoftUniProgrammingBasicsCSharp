using System;

class VowelsSum
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();

        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            switch (text[i])
            {
                case 'a': sum += 1; break;
                case 'e': sum += 2; break;
                case 'i': sum += 3; break;
                case 'o': sum += 4; break;
                case 'u': sum += 5; break;
                default: sum += 0; break;
            }
        }
        Console.WriteLine(sum);


        /*
         * for (i = 0; i < text.Length; i++)
         * sum += "aeiou".IndexOf(text[i]) + 1;
        */


                /*
                * case 'u': sum++;
                * case 'o': sum++;
                * case 'i': sum++;
                * case 'e': sum++;
                * case 'a': sum++;break;
                */
}
}
