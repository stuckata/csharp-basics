using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company Name: ");
        string compName = Console.ReadLine();
        Console.Write("Addres: ");
        string address = Console.ReadLine();
        Console.Write("Company Phone Number: ");
        int compPhoneNum = int.Parse(Console.ReadLine());
    }
}