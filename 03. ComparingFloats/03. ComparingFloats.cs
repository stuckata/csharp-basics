using System;

class ComparingFloats
{
    static void Main()
    {
        float eps = 0.000001f;
        //Just another possible solution if input has to be from console:
        //Console.WriteLine("Please, enter the first number of type float and confirm with ENTER: ");
        //float numberA = float.Parse(Console.ReadLine());
        //Console.WriteLine("Please, enter the second number of type float and confirm with ENTER: ");
        //float numberB = float.Parse(Console.ReadLine());

        float numberA = 5.002f;
        float numberB = 5.003f;
        float temp = Math.Abs(numberA - numberB);
        bool check = (temp < eps);

        Console.WriteLine("The two numbers are: " + numberA + " and " + numberB);
        Console.WriteLine("Are they equal?");
        Console.WriteLine(check == true ? "The two \"float\" variables are equal" : "The two \"float\" variables are not equal");

    }
}