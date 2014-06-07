using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("This check whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. The numbers should be != 0");
        Console.WriteLine("Enter integer numbers to be checked in one line separated by a space: ");

        string[] input = Console.ReadLine().Split(' ');
        int number = 0;
        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < input.Length; i++)
        {
            bool isValid = int.TryParse(input[i], out number);
            while (!isValid || number == 0)
            {
                Console.WriteLine("Invalid numbers! Enter again: ");
                input = Console.ReadLine().Split(' ');
                isValid = int.TryParse(input[i], out number);
            }
            if (i % 2 == 0)
            {
                productOdd *= number;
            }
            else
            {
                productEven *= number;
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", productOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("product_odd = {0}", productOdd);
            Console.WriteLine("product_even = {0}", productEven);
        }
    }
}

