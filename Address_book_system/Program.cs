using Address_book_system;
internal class program
{
    public static List<Person_Details> details = new List<Person_Details>();

    public static void Main(String[] args)
    {
        Address_book_system.person.createNewContact();
        Address_book_system.person.displayContacts();
        Address_book_system.person.editContact();
        Address_book_system.person.displayContacts();
        Address_book_system.person.deleteContact();
        Address_book_system.person.displayContacts();
    }
}