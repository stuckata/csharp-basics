using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullIntegerVariable = null;
        double? nullDoubleVariable = null;

        Console.WriteLine(nullIntegerVariable); //printing the result
        Console.WriteLine(nullDoubleVariable);
        Console.WriteLine(nullIntegerVariable.HasValue); //checking for value
        Console.WriteLine(nullDoubleVariable.HasValue);

        int integerNum = 5;
        nullIntegerVariable = nullIntegerVariable + integerNum; //sum of "null" and integer

        Console.WriteLine(nullIntegerVariable); //printing the result
        Console.WriteLine(nullIntegerVariable.HasValue); //checking for value

        nullIntegerVariable = integerNum; //assigning an integer value to "null"

        Console.WriteLine(nullIntegerVariable); //printing the result

        double doubleNum = 5.45879d;
        nullDoubleVariable = nullDoubleVariable + doubleNum; //sum of "null" and double

        Console.WriteLine(nullDoubleVariable); //printing the result
        Console.WriteLine(nullDoubleVariable.HasValue); //checking the value

        nullDoubleVariable = doubleNum; //assigning a double value to "null"

        Console.WriteLine(nullDoubleVariable);
    }
}