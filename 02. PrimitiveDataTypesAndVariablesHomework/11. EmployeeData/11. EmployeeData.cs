using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 31;
        bool genderFemale = false; //true or false depending on gender
        long personalID = 8306112507L;
        uint uniquePersonalNumber = 27569999u;

        Console.WriteLine("Name of employee: {0} {1}", firstName, lastName, age);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine(genderFemale == true ? "Gender: Female" : "Gender: Male"); //check gender
        Console.WriteLine("Personal ID: {0}", personalID);
        Console.WriteLine("Unique Personal Number: {0}", uniquePersonalNumber);
    }
}