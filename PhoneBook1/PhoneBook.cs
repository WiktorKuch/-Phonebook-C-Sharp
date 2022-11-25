using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook1
{
    internal class PhoneBook
    {
        List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);

        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($" Contact : {contact.Name}, {contact.Number}");
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts?.FirstOrDefault(x => x.Number == number);
            if(contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }

        }

        public void DisplayAllContacts()
        {

            DisplayContactDetails(Contacts);

        }

        public void DisplayMatchingContact(string searchfrase)
        {
#pragma warning disable CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
            var matchingContacts = Contacts.Where(c=> c.Name.Contains(searchfrase)).ToList();
#pragma warning restore CS8602 // Wyłuskanie odwołania, które może mieć wartość null.

            DisplayContactDetails(matchingContacts);

        }
           

           
            

        }


    }

