using System;
namespace PhoneBook1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1 Add contact ");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contact ");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("To exit insert 'x' ");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number ");
                        var number = Console.ReadLine();

                        Console.WriteLine("Insert name of contact");
                        var name = Console.ReadLine();

#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
                        var newContact = new Contact(name, number);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":

                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();

#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
                        phoneBook.DisplayContact(numberToSearch);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.

                        break;

                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":

                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
                        phoneBook.DisplayMatchingContact(searchPhrase);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Invalid operation");

                        break;

                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }

            

                

        }
    }
}