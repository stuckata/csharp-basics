using System;

class ApplyingBonusScore
{
    static void Main()
    {
        Console.WriteLine("This program will apply a bonus based on given score.");
        Console.WriteLine("Enter score in a range 1 - 9: ");

        int score = int.Parse(Console.ReadLine());
        int multiplier10X = 10;
        int multiplier100X = 100;
        int multiplier1000X = 1000;
        string text = "The bonus is: ";

        switch (score)
        {
            case 1:
                Console.WriteLine(text + (score *= multiplier10X));
                break;
            case 2:
                Console.WriteLine(text + (score *= multiplier10X));
                break;
            case 3:
                Console.WriteLine(text + (score *= multiplier10X));
                break;
            case 4:
                Console.WriteLine(text + (score *= multiplier100X));
                break;
            case 5:
                Console.WriteLine(text + (score *= multiplier100X));
                break;
            case 6:
                Console.WriteLine(text + (score *= multiplier100X));
                break;
            case 7:
                Console.WriteLine(text + (score *= multiplier1000X));
                break;
            case 8:
                Console.WriteLine(text + (score *= multiplier1000X));
                break;
            case 9:
                Console.WriteLine(text + (score *= multiplier1000X));
                break;
            default:
                Console.WriteLine("Invalid Score!");
                break;
        }
    }
}
