using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_system
{
    internal class person
    {
        public static List<Person_Details> details = new List<Person_Details>();
        //uc1 create contact

        public Dictionary<string, List<Person_Details>> group = new Dictionary<string, List<Person_Details>>();

        public static void createNewContact()
        {
            Person_Details contact = new Person_Details();
            Console.WriteLine("Enter the First name : ");
            contact.first_Name = Console.ReadLine();

            var per = details.FirstOrDefault(p => p.Equals(contact));
            if (per == null)
            {
                Console.WriteLine("Enter the Last name : ");
                contact.last_Name = Console.ReadLine();

                Console.WriteLine("Enter the Address : ");
                contact.address = Console.ReadLine();

                Console.WriteLine("Enter the City : ");
                contact.city = Console.ReadLine();

                Console.WriteLine("Enter the State : ");
                contact.state = Console.ReadLine();

                Console.WriteLine("Enter the Zip : ");
                contact.zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Phone number : ");
                contact.phone_Number = Console.ReadLine();

                Console.WriteLine("Enter the Email Id : ");
                contact.email = Console.ReadLine();

                // uc2 add contact
                details.Add(contact);
            }
            else
            {
                Console.WriteLine("This Person name and details already exists");
            }
        }

        public void displayContacts()
        {
            if (details.Count == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }
            Console.WriteLine("1.Total Contacts\n2.Group");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("List of contacts:\n");
                    foreach (var contact in details)
                    {
                        Console.WriteLine("First Name: " + contact.first_Name);
                        Console.WriteLine("Last Name: " + contact.last_Name);
                        Console.WriteLine("Address: " + contact.address);
                        Console.WriteLine("City: " + contact.city);
                        Console.WriteLine("State: " + contact.state);
                        Console.WriteLine("Zip Code: " + contact.zip);
                        Console.WriteLine("Contact No.: " + contact.phone_Number);
                        Console.WriteLine("Email address: " + contact.email);
                        Console.WriteLine("--------------------------------------------------");
                    }
                    break;
                case 2:
                    foreach (string key in group.Keys)
                    {
                        Console.WriteLine(key);
                    }

                    Console.WriteLine("Enter group you want to display.");
                    string gName = Console.ReadLine();
                    List<Person_Details> list = group[gName];

                    foreach (var contact in list)
                    {
                        Console.WriteLine("First Name: " + contact.first_Name);
                        Console.WriteLine("Last Name: " + contact.last_Name);
                        Console.WriteLine("Address: " + contact.address);
                        Console.WriteLine("City: " + contact.city);
                        Console.WriteLine("State: " + contact.state);
                        Console.WriteLine("Zip Code: " + contact.zip);
                        Console.WriteLine("Contact No.: " + contact.phone_Number);
                        Console.WriteLine("Email address: " + contact.email);
                        Console.WriteLine("--------------------------------------------------");
                    }
                    break;
            }


        }
        //uc3 edit contact
        public static void editContact()
        {
            Console.WriteLine("Enter the name to edit the person's details : ");
            string name = Console.ReadLine();

            foreach (var contact in details)
            {
                if (contact.first_Name.Equals(name))
                {
                    Console.WriteLine("Which field you want to edit:\n1.First Name\n2.last Name\n3.Address\n4.city\n5.state\n6.zip\n7.Phone number.\n8.Email");
                    Console.WriteLine("Enter your choice:");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name to update:");
                            contact.first_Name = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name to update:");
                            contact.last_Name = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter Address to update:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter City to update:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter State to update:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip code to update:");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone to update:");
                            contact.phone_Number = Convert.ToString(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter Email to update:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Invalid option:");
                            break;
                    }
                }
            }

        }
        //uc4 delete contact
        public static void deleteContact()
        {
            Console.WriteLine("Enter Name to delete the person's details: ");
            string name = Console.ReadLine();

            foreach (var contact in details.ToList())
            {
                if (contact.first_Name.Equals(name))
                {
                    details.Remove(contact);
                }
            }
        }
        //uc5 add multiple person to address book
        public void addMultiContacts()
        {
            Console.WriteLine("Number of contacts needed to add to the Address Book : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                createNewContact();
                n--;
            }
        }
        //uc6 Add multiple Address Book
        public void addMultiAddressBooks()
        {
            Console.WriteLine("Number of address books need to add: ");
            int noOfAddressBooks = Convert.ToInt32(Console.ReadLine());
            while (noOfAddressBooks > 0)
            {
                Console.WriteLine("Enter group name:");
                string gName = Console.ReadLine();
                person people = new person();
                people.addMultiContacts();
                group.Add(gName, details.ToList());
                noOfAddressBooks--;
            }
        }
        //uc8 search person by city or state across multiple address book
        public void searchPersonCityOrState()
        {
            Console.WriteLine("Enter the name of state or city to search the person :");
            string value = Console.ReadLine();
            foreach (var Person_Details in group.Values)
            {
                List<Person_Details> city = details.FindAll(p => p.city.ToLower() == value.ToLower());
                List<Person_Details> state = details.FindAll(p => p.state.ToLower() == value.ToLower());
                if (city.Count != 0)
                {
                    Console.WriteLine("All contacts in city {0} are:", value);
                    foreach (var contact in city)
                    {
                        Console.WriteLine("Name:{0} {1}", contact.first_Name, contact.last_Name);
                    }
                }
                else if (state.Count != 0)
                {
                    Console.WriteLine("All contacts in state {0} are:", value);
                    foreach (var contact in state)
                    {
                        Console.WriteLine("Name:{0} {1}", contact.first_Name, contact.last_Name);
                    }
                }
                else
                    Console.WriteLine("No contacts available in the required city or state");
            }
        }
    }
}
