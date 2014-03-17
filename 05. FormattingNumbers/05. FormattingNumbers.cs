using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer \"a\" which fulfill following condition 0 <= a <= 500: ");
        int numA = int.Parse(Console.ReadLine());
        if (numA < 0 || numA > 500)
        {
            Console.WriteLine("\"a\" do not fulfill 0 <= a <= 500!");
            return;
        }
        Console.WriteLine("Enter two floating-point variable \"b\": ");
        float numB = float.Parse(Console.ReadLine());
        Console.WriteLine("And \"c\": ");
        float numC = float.Parse(Console.ReadLine());

    }
}

