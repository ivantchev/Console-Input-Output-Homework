using System;
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Company fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Company web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();

        Console.Write("First last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Manager Phone number: ");
        string managerNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company details.");
        Console.WriteLine("Name:         {0,-20}", companyName);
        Console.WriteLine("Address:      {0,-20}", companyAddress);
        Console.WriteLine("Phone:        {0,-20}", companyPhoneNumber);
        Console.WriteLine("Fax:          {0,-20}", faxNumber);
        Console.WriteLine("Web site:     {0,-20}", webSite);
        Console.WriteLine("\nManager details.");
        Console.WriteLine("First name:   {0,-20}", firstName);
        Console.WriteLine("Last name:    {0,-20}", lastName);
        Console.WriteLine("Age:          {0,-20}", age);
        Console.WriteLine("Phone number: {0,-20}", managerNumber);

    }
}

