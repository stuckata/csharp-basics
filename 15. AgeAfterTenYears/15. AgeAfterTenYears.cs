using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        int ageAfterTenYears = 0;
        Console.Write("Please enter your years: ");
        int age = int.Parse(Console.ReadLine());
        ageAfterTenYears = age + 10;
        Console.WriteLine("You are now " + age + " and after 10 years you will be " + ageAfterTenYears + " years old.");
    }
}
