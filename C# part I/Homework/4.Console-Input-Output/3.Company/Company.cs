using System;

class Company
{
    static void Main()
    {
        Console.WriteLine("Enter company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter company phone number:");
        string companyPhoneNum = Console.ReadLine();
        Console.WriteLine("Enter company fax number:");
        string FaxNum =Console.ReadLine();
        Console.WriteLine("Enter company web site:");
        string website =Console.ReadLine();
        Console.WriteLine("Enter manager's first name:");
        string fName =Console.ReadLine();
        Console.WriteLine("Enter manager's last name:");
        string lName =Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age =int.Parse(Console.ReadLine());
        Console.WriteLine("Enter phone number:");
        string phoneNum =Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("THE COMPANY:");
        Console.WriteLine("Name:        {0}" ,companyName);
        Console.WriteLine("Addres:      {0}",companyAddress);
        Console.WriteLine("Phone Number:{0}",companyPhoneNum);
        Console.WriteLine("Fax Number:  {0}",FaxNum );
        Console.WriteLine("Web site:    {0}\n", website);
        Console.WriteLine("The MANAGER:");
        Console.WriteLine("Manager's first name:{0}" ,fName);
        Console.WriteLine("Manager's last name: {0}", lName);
        Console.WriteLine("Age:                 {0}", age);
        Console.WriteLine("Phone number:        {0}", phoneNum);
    }
}


