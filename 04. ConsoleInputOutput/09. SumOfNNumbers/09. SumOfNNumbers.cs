using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("This program calculates the sum of N numbers.");
            Console.WriteLine("Please, enter the number of digits for calculating their sum: ");

            int numN = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numN; i++)
            {
                Console.WriteLine("Enter {0} number: ", i);
                double temp = double.Parse(Console.ReadLine());
                sum += temp;
            }
            Console.WriteLine("The sum of {0} numbers is: {1}", numN, sum);
        }
    }
