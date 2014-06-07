using System;
using System.Globalization;

public class WriteAMethodAndTestResult
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        string formattedName = FormatName(name);
        PrintHelloName(formattedName);
    }

    static string FormatName(string name)
    {
        string formattedName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
        return formattedName;
    }

    static void PrintHelloName(string name)
    {
        Console.WriteLine("Hello, {0}", name);
    }
}

