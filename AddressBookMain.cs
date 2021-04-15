using System;

namespace Address_Book_System
{    /* UC1:- Ability to create a Contacts in Address Book with first and last names, address, city, state, zip, phone number and
              email...
              - Program is written using IDE like IntelliJ
              - Every UC is in a separate Git Branch and then merged with main
              - Naming Convention, Indentation, etc Code Hygiene will be checked during Review
              - Git Check In Comments and Version History will be monitored
    */
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
