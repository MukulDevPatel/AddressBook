using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Entry");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option\n1. Add Contact\n2. Edit Contact\n3. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                AddressBookMain addressBook = new AddressBookMain();
                switch (option)
                {
                    case 1:
                        for (int i = 0; i < 2; i++)
                        {
                            addressBook.AddContact();
                        }
                        addressBook.Display();
                        break;
                     case 2:
                        addressBook.EditContact();
                        addressBook.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                        
                }
            }
        }
    }
}
