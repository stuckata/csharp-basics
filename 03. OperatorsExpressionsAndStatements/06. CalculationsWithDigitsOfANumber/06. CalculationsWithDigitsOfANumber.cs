using System;

class CalculationsWithDigitsOfANumber
{
    static void Main()
    {
        Console.WriteLine("Please enter four-digit integer which do NOT start with 0:");
        int fourDigitInteger = int.Parse(Console.ReadLine());
        int fourthDigit = fourDigitInteger % 10; //digits are left to right numbered
        int thirdDigit = (fourDigitInteger / 10) % 10;
        int secondDigit = (fourDigitInteger / 100) % 10;
        int firstDigit = (fourDigitInteger / 1000) % 10;

        int sumDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        string reversedDigits = "" + fourthDigit + thirdDigit + secondDigit + firstDigit;
        string lastDigitFirst = "" + fourthDigit + firstDigit + secondDigit + thirdDigit;
        string exchangeSecondAndThird = "" + firstDigit + thirdDigit + secondDigit + fourthDigit;

        Console.WriteLine("The sum of digits is: " + sumDigits);
        Console.WriteLine("The digits in reversed order: " + reversedDigits);
        Console.WriteLine("If the last digit is at first place the number is: " + lastDigitFirst);
        Console.WriteLine("If we exchange the second and third digits the number is: " + exchangeSecondAndThird);
    }
}
