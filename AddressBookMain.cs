using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
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
        }
        public void Display()
        {
            Console.WriteLine(contact.FirstName+"\n"+contact.LastName+"\n"+contact.Address+"\n"+contact.Address+"\n"+contact.City+"\n"+contact.State+"\n"+contact.Zip+"\n"+contact.PhoneNumber+"\n"+contact.Email);
        }
    }
}
