using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();
        Contact contact = new Contact();
        public void AddContact()
        {
            Console.WriteLine("Enter first name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void EditContact()
        {
            Console.WriteLine("Edit using First name");
            string name = Console.ReadLine();
            foreach (var data in addressBook)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("Enter option to edit\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. ZIP\n7. Phone Number\n8. Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            data.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            data.LastName = Console.ReadLine();
                            break;
                        case 3:
                            data.Address = Console.ReadLine();
                            break;
                        case 4:
                            data.City = Console.ReadLine();
                            break;
                        case 5:
                            data.State = Console.ReadLine();
                            break;
                        case 6:
                            data.Zip = Console.ReadLine();
                            break;
                        case 7:
                            data.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            data.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter name to delete contact");
            string name = Console.ReadLine() ;
            foreach (var data in addressBook)
            {
                if (data.FirstName.Equals(name))
                {
                    addressBook.Remove(data);
                }
            }
        }
        public void Display()
        {
            foreach (var data in addressBook)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }
        }
        public void MultiplePersonAddress()
        {
            Console.WriteLine("Add new person details");
            Console.WriteLine("Enter first name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void RefactorMultipleAddressBook()
        {
            Dictionary<string,List<Contact>> addressBooks = new Dictionary<string,List<Contact>>();
            while (true)
            {
                Console.WriteLine("Enter address book name or type 'exit' ");
                string bookName = Console.ReadLine();
                
                if (bookName.ToLower() == "exit")
                { break; }
                
                if (addressBooks.ContainsKey(bookName))
                {
                    Console.WriteLine("{0} Address Book is exist",bookName);
                }
                else { addressBooks.Add(bookName, addressBook);
                    Console.WriteLine("{0} Address book added.\n",bookName);
                    bool flag = true;
                    while (flag) 
                    { 
                        Console.WriteLine("1. Enter person's details \n2. Type 'exit' ");
                        AddressBookMain address = new AddressBookMain();
                        address.AddContact();
                        address.Display();
                        flag = false;
                        break;
                    }
                }
            }
        }

    }
}
