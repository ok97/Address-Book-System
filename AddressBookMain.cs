using System;

namespace Address_Book_System
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome To AddressBook *******");
          
            Console.Write("Enter First Name:- ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name:- ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address:- ");
            string address = Console.ReadLine();
            Console.Write("Enter City:- ");
            string city = Console.ReadLine();
            Console.Write("Enter State:- ");
            string state = Console.ReadLine();
            Console.Write("Enter Zip Code :- ");
            string zip = Console.ReadLine();
            Console.Write("Enter Phone Number:- ");
            string pNumber = Console.ReadLine();
            Console.Write("Enter Email:- ");
            string Email = Console.ReadLine();
        }
    }
}
