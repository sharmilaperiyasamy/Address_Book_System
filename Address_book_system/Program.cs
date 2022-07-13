using Address_book_system;
internal class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("1.Create new Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts" +
            "\n5.Add Multiple Contacts\n6.Add Multiple Address Books\n7.Search name by City or State\n8.View name by City or State" +
            "\n9.Count contact persons i.e. count by city or state\n10.Read/write person contacts into file using fileIO\n11.Exit\n");
        Console.WriteLine("Enter your choice:");
        int option = Convert.ToInt32(Console.ReadLine());
        Address_book_system.person books = new Address_book_system.person();
        while (option != 11)
        {
            //Console.Clear();

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
                    books.displayContacts();
                    break;
                case 5:
                    books.addMultiContacts();
                    break;
                case 6:
                    books.addMultiAddressBooks();
                    break;
                case 7:
                    books.searchPersonCityOrState();
                    break;
                case 8:
                    books.searchPersonCityOrState();
                    break;
                case 9:
                    books.getCountContactpersons();
                    break;
                case 10:
                    books.writeIntoFileUsingIO();
                    books.readFromFileUsingIO();
                    break;
                default:
                    Console.Write("Enter valid option.\n");
                    break;

            }
            Console.WriteLine("1.Create new Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts" +
                "\n5.Add Multiple Contacts\n6.Add Multiple Address Books\n7.Search name by City or State" +
                "\n8.View name by City or State\n9.Count contact persons i.e. count by city or state\n10.Read/write person contacts into file using fileIO\n11.Exit\n");
            Console.WriteLine("Enter your choice:");
            option = Convert.ToInt32(Console.ReadLine());

        }
    }
}