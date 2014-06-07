using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please, enter coefficients a, b, c of quadratic equation ax*x + bx + c = 0: ");
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        double discriminant = (numB * numB) - (4 * numA * numC);
        double rootX1 = 0;
        double rootX2 = 0;

        if ((numA == 0 && numB == 0) || (discriminant < 0))
        {
            Console.WriteLine("The equation do NOT have real roots!");
            return;
        }
        if (numA == 0 && numB != 0)
        {
            rootX1 = (-numC) / numB;
            Console.WriteLine("The equation has only one real root x = {0}", rootX1);
            return;
        }
        if (numA != 0 && discriminant == 0)
        {
            rootX1 = (-numB) / (2 * numA);
            rootX2 = rootX1;
            Console.WriteLine("The equation has two equal real roots x1 = x2 = {0}", rootX1);
            return;
        }
        rootX1 = ((-numB) - Math.Sqrt(discriminant)) / (2 * numA);
        rootX2 = ((-numB) + Math.Sqrt(discriminant)) / (2 * numA);
        
        Console.WriteLine("The equation has two real roots x1 = {0} and x2 = {1}", rootX1, rootX2);
    }
}
