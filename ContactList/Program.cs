using System;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact By Number");
            Console.WriteLine("3. View All Numbers");
            Console.WriteLine("4. Search for Contacts from a given name");
            Console.WriteLine("Press x to Exit");

            var input = Console.ReadLine(); 
            
            var contactList = new ContactList();

            while(true)
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        contactList.AddContact(newContact);

                        break;
                        
                    case "2":
                        Console.WriteLine("Contact Number to search:");
                        var searchNumber = Console.ReadLine();
                        contactList.DisplaySpecificContact(searchNumber);

                        break;

                    case "3":
                        contactList.DisplayAll();
                        break;

                    case "4":
                        Console.WriteLine("Name to Search:");
                        var word = Console.ReadLine();

                        contactList.FindContact(word);

                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select Valid Operation");
                        break;
                }
                Console.WriteLine("Select Operation");
                input = Console.ReadLine();
            }
            
        }
    }
}
