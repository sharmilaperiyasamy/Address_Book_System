using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_system
{
    internal class person
    {
        //uc1 create contact
        public static void createNewContact()
        {
            Person_Details contact = new Person_Details();
            Console.WriteLine("Enter the First name : ");
            contact.first_Name = Console.ReadLine();

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
            program.details.Add(contact);
        }

        public static void displayContacts()
        {
            if (program.details.Count == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }
            Console.WriteLine("List of contacts:\n");
            foreach (var contact in program.details)
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

        }
        //uc3 edit contact
        public static void editContact()
        {
            Console.WriteLine("Enter the name to edit the person's details : ");
            string name = Console.ReadLine();

            foreach (var contact in program.details)
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

            foreach (var contact in program.details.ToList())
            {
                if (contact.first_Name.Equals(name))
                {
                    program.details.Remove(contact);
                }
            }
        }
        //uc5 add multiple person to address book
        public static void addMultiContacts()
        {
            Console.WriteLine("Number of contacts needed to add to the Address Book : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                createNewContact();
                n--;
            }
        }
    }
}
