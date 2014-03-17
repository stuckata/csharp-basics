using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company Name: ");
        string compName = Console.ReadLine();
        Console.WriteLine("Addres: ");
        string address = Console.ReadLine();
        Console.WriteLine("Phone Number: ");
        string telNum = Console.ReadLine();
        Console.WriteLine("Fax Number: ");
        string faxNum = Console.ReadLine();
        Console.WriteLine("Web Site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager First Name: ");
        string mngrFName = Console.ReadLine();
        Console.WriteLine("Manager Last Name: ");
        string mngrLName = Console.ReadLine();
        Console.WriteLine("Manager Age: ");
        int mngrAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Manager Telephone Number: ");
        string mngrTelNum = Console.ReadLine();

        Console.WriteLine("Company Name: " + compName);
        Console.WriteLine("Adress: " + address);
        Console.WriteLine("Phone Number: " + telNum);
        Console.WriteLine("Fax Number: " + faxNum);
        Console.WriteLine("Web Site: " + webSite);
        Console.WriteLine("Manager First, Last Names and Age: " + mngrFName + " " + mngrLName + " " + mngrAge + " years old.");
        Console.WriteLine("Manager Telephone Number: " + mngrTelNum);
    }
}