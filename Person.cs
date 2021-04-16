using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{    /*     Ability to add a new Contact to Address Book - Use Console to add person details from AddressBookMain class
            - Use Object Oriented Concepts to manage relationship between AddressBook and Contact Person
    */
    class Person
    {
        private String lname, address, city, state, phone, zip, email; //Declaring (Creating) Variables
        public Person(String fname, String lname, String address, String city, String state, String phone, String zip,string email)
        {                                                   //constructor
            this.FirstName = fname;
            this.LastName = lname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNo = phone;
            this.ZipCode = zip;
            this.email = email;
        }

        public string FirstName { get; set; }         // get method returns the value of the variable FirstName.
                                                      // set method assigns a value to the name variable.
        public string LastName { get => lname; set => lname = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNo { get => phone; set => phone = value; }
        public string ZipCode { get => zip; set => zip = value; }
        public string Email { get => email; set => email = value; }
        public override string ToString() //Tostring  method store value
        {
            return "FirstName:- " + FirstName + "\nLastName:- " + LastName + " \nAddress:- " + Address + " \nCity:- " + City
                 + "\nState:- " + State + "\nZipCode:- " + ZipCode + "\nPhoneNo:- " + PhoneNo + "\nEmail:- " + email+" " + "\n";
        }
    }
}
