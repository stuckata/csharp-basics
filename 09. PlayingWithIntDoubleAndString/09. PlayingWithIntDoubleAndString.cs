using System;

class PlayingWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Depending on the user’s choice, this program inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends \" * \" at the end.");
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine();
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Please enter an int: ");
                int numInt = int.Parse(Console.ReadLine());
                numInt = numInt + 1;
                Console.WriteLine(numInt);
                break;

            case "2":
                Console.Write("Please enter a double: ");
                double numDouble = double.Parse(Console.ReadLine());
                numDouble = numDouble + 1;
                Console.WriteLine(numDouble);
                break;

            case "3":
                Console.Write("Please enter a string: ");
                string word = Console.ReadLine();
                word = word + "*";
                Console.WriteLine(word);
                break;

            default:
                Console.WriteLine("Not a valid type!");
                break;
        }
    }
}

