using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = 8;
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            int checkPrimeNum = number % i;
            if (checkPrimeNum == 0) // checking for reminder dividing by numbers < number 
            {
                isPrime = false;
                break;
            }
        }
        if ((number <= 0) || (number == 1))
        {
            isPrime = false;
        }
        if (number == 2)
        {
            isPrime = true;
        }
        Console.WriteLine(isPrime == true ? "Prime number." : "Not a prime number.");
    }
}
