using System;

    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer: ");
            int numN = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is: " + numN);

            for (int i = 1; i <= numN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
