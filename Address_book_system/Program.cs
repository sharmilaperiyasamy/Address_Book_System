using Address_book_system;
internal class program
{
    public static List<Person_Details> details = new List<Person_Details>();

    public static void Main(String[] args)
    {
        Console.WriteLine("1.Create new Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Exit\n");
        Console.WriteLine("Enter your choice:");
        int option = Convert.ToInt32(Console.ReadLine());
        while (option != 6)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    Address_book_system.person.createNewContact();
                    break;
                case 2:
                    Address_book_system.person.editContact();
                    break;
                case 3:
                    Address_book_system.person.deleteContact();
                    break;
                case 4:
                    Address_book_system.person.displayContacts();
                    break;
                case 5:
                    Address_book_system.person.addMultiContacts();
                    break;
                default:
                    Console.Write("Enter valid option.\n");
                    break;

            }
            Console.WriteLine("1.Create new Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Exit\n");
            Console.WriteLine("Enter your choice:");
            option = Convert.ToInt32(Console.ReadLine());

        }
    }
}