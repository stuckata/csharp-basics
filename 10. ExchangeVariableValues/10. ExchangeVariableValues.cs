using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = 0; //for the exchange use third variable

        Console.WriteLine("The two numbers are: a = {0} and b = {1}", a, b);

        c = b; //get the value of one of the variables to not loose it after exchange
        b = a;
        a = c;

        Console.WriteLine("After changing their values the result is: a = {0} and b = {1}", a, b);
    }
}