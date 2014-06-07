using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer a which fulfill following condition 0 <= a <= 500: ");
        int numA = int.Parse(Console.ReadLine());
        if (numA < 0 || numA > 500)
        {
            Console.WriteLine("a should fulfill 0 <= a <= 500!");
            return;
        }
        Console.WriteLine("Enter floating-point variable b: ");
        float numB = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter floating-point variable c: ");
        float numC = float.Parse(Console.ReadLine());

        string symbol = "|";
        string numAHex = Convert.ToString(numA, 16).PadRight(10, ' ');
        numAHex = numAHex.ToUpper();
        string numABin = Convert.ToString(numA, 2).PadLeft(10, '0');
        Console.WriteLine("{0}{1}{0}{2}{0}{3,10:0.##}{0}{4,-10:0.000}{0}", symbol, numAHex, numABin, numB, numC);
    }
}

