using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressBook = new AddressBookMain();
            Console.WriteLine("Address Book Entry");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option\n1. Add Contact\n2. Edit Contact\n3. Delete Contact\n4. Display\n5. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.AddContact();
                        addressBook.Display();
                        break;
                     case 2:
                        addressBook.EditContact();
                        addressBook.Display();
                        break;
                    case 3:
                        addressBook.DeleteContact();
                        addressBook.Display();
                        break;
                    case 4:
                        addressBook.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                        
                }
            }
        }
    }
}
