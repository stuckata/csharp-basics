using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNamesFromList
{
    static void Main()
    {
        Console.WriteLine("This program allows you to enter or remove names from a list.");
        Console.WriteLine();
        List<string> names = DecideAddOrRemove();
    }

    static List<string> DecideAddOrRemove(List<string> names)
    {
        Console.WriteLine("Enter a choice 1 to add or 2 to remove a name: ");
        Console.WriteLine("1 To enter a name.");
        Console.WriteLine("2 To remove a name.");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                names = AddName(names);
                break;
            case "2":
                names = RemoveName(names);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
        return names;
    }

    static List<string> AddName(List<string> namesList)
    {
        Console.Write("Add a name to list: ");
        string name = Console.ReadLine();
        namesList.Add(name);
        return namesList;
    }

    static List<string> RemoveName(List<string> namesList)
    {
        Console.Write("Remove a name form a list: ");
        string name = Console.ReadLine();
        bool isValidName = namesList.Exists(n => name.ToLower().Equals(n));
        if (!isValidName)
        {
            Console.WriteLine("Name not found in the list");
            DecideAddOrRemove(namesList);
        }
        else
        {
        
        }
    }
}


