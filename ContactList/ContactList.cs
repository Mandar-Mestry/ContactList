using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    class ContactList
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();

        private void DisplayDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplaySpecificContact(string number)
        {
            var contact = contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact Not Found");
            }
            else
            {
                DisplayDetails(contact);
            }
        }

        public void DisplayAll()
        {
            foreach(var contact in contacts)
            {
                DisplayDetails(contact);
            }
        }

        public void FindContact(string search)
        {
            var matchingContact = contacts.Where(c => c.Name.Contains(search)).ToList();
            foreach(var contact in matchingContact)
            {
                DisplayDetails(contact);
            }
        }
    }
}
