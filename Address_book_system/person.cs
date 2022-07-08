using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_system
{
    internal class person
    {
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

            Directory.details.Add(contact);
        }
    }
}
