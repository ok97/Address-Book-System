using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Address_Book_System
{           /*   UC6:- Refactor to add multiple Address Book to the System.Each Address Book has a unique Name 
                     - Use Console to add new Address Book - Maintain Dictionary of Address Book Name to Address Book
            */
    class Edit  // Class Edit
    {
        public static bool PhoneNumberValidation(String phone)
        {
            String PPattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"; //Define Phone Number Pattern
            Regex Pregex = new Regex(PPattern); //create object of the Regex class (its Regesx predefine class)
            return Pregex.IsMatch(phone);
        }
        public static bool EmailValidation(String email)
        {
            String Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$"; //Define Email Pattern
            Regex eregex = new Regex(Epattern); //create object of the Regex class (its Regesx predefine class)
            return eregex.IsMatch(email);

        }
        public static bool ZipValidation(String zip)  //Zip Method
        {
            String ZPattern = "^[0-9]{6}(?:-[0-9]{6})?$";  //Define Zip Code Pattern
            Regex Zregex = new Regex(ZPattern); //create object of the Regex class (its Regesx predefine class)
            return Zregex.IsMatch(zip);
        }

        Person person = null;

        List<Person> list = new List<Person>(); //create a list of Person objects

        String fname = null; //empty string
        String lname, address, city, state, phone, zip, email; //Declaring (Creating) Variables

        public void AddRecord() //Addidng Record method
        {
            int i = 0;
            while (i == 0) // Checking name exixt or not
            {
                Console.Write("Enter First Name:- "); //take input user First name
                this.fname = Console.ReadLine();   //Store input fname            
                if (CheckExist(fname))  //Checking for duplicates firstname or user input are same or not
                {
                    Console.WriteLine($"Record with name { fname } Already Exist\n Please Enter New name:-");//print name Already Exist
                }
                else
                {
                    i = 1;
                }
            }
            Console.Write("Enter Last Name:- "); //Take input user
            lname = Console.ReadLine();            //Store input for lname
            Console.Write("Enter Address:- "); //Take input user
            address = Console.ReadLine();       //Store input for address
            Console.Write("Enter City:- "); //Take input user
            city = Console.ReadLine();        //Store input for city
            Console.Write("Enter State:- "); //Take input user
            state = Console.ReadLine();        //Store input for state
            Console.Write("Enter Zip:- "); //Take input user
            zip = Console.ReadLine();         //Store input for zip
            while (!ZipValidation(zip))
            {
                Console.Write(zip + " is Invalid Zip Code \nPlease Enter Valid Zip:- ");
                zip = Console.ReadLine();
            }

            Console.Write("Enter Phone Number:- "); //Take input user
            phone = Console.ReadLine();           //Store input for phone
            while (!PhoneNumberValidation(phone))
            {
                Console.Write(phone + " is Invalid Phone Number \nPlease Enter Valid Number:- ");
                phone = Console.ReadLine();
            }

            Console.Write("Enter Email:- ");  //Take input user
            email = Console.ReadLine();           //Store input for email

            while (!EmailValidation(email))
            {
                Console.Write(email + " is Invalid Email \nPlease Enter Valid Email:- ");
                email = Console.ReadLine();
            }

            person = new Person(fname, lname, address, city, state, phone, zip, email);
            list.Add(person);   //adding list data person
        }
        public void DisplayRecord()  //Display Record Method
        {
            if (list.Count == 0) //Check list ==0
            {
                Console.WriteLine(" No Records Found"); //print record not found
            }
            else
            {
                foreach (Person k in list)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public void EditRecord(String fname) // EditRecord Method 
        {
            for (int k = 0; k < list.Count; k++) // Value  present or not
            {
                if (list[k].FirstName.Equals(fname))
                {
                    Person person = list[k];
                    Console.WriteLine(person);  //Print person

                    while (k == 0)  // k==0 to edite contact
                    {
                        Console.WriteLine("What Do You Want to edit Contact Details \n"
                                + "1. Address\n"
                                + "2. city\n"
                                + "3. State\n"
                                + "4. Zip Code\n"
                                + "5. Phone\n"
                                + "6. Email\n"
                                + "7. Save And Exit\n");

                        int choice = Convert.ToInt32(Console.ReadLine());  //convert string and store choice
                        switch (choice)  //case 
                        {
                            case 1:
                                Console.Write("Enter new Address:-  ");  //Take input user
                                String address = Console.ReadLine();   //store address veriable
                                person.Address = address;  //store class of person address data
                                break;
                            case 2:
                                Console.Write("Enter new City:- "); //Take input user
                                String city = Console.ReadLine();  //store city veriable
                                person.City = city;                 //store class of person city data
                                break;
                            case 3:
                                Console.Write("Enter new State:- "); //Take input user
                                String state = Console.ReadLine();   //store state veriable
                                person.State = state;               //store class of person state data
                                break;
                            case 5:
                                Console.Write("Enter new Phone:- "); //Take input user
                                String phone = Console.ReadLine();   //store phone veriable
                                while (!PhoneNumberValidation(phone))
                                {
                                    Console.Write(phone + " is Invalid Phone Number \nPlease Enter Valid Number:- ");
                                    phone = Console.ReadLine();
                                }
                                person.PhoneNo = phone;                 //store class of person phone data
                                break;
                            case 4:
                                Console.Write("Enter new Zip Code:- "); //Take input user
                                String zip = Console.ReadLine();        //store zip veriable
                                while (!ZipValidation(zip))
                                {
                                    Console.Write(zip + " is Invalid Zip Code \nPlease Enter Valid Zip:- ");
                                    zip = Console.ReadLine();
                                }
                                person.ZipCode = zip;                       //store class of person zip data
                                break;
                            case 6:
                                Console.Write("Enter new Email:- "); //Take input user
                                String email = Console.ReadLine();
                                while (!EmailValidation(email))
                                {
                                    Console.Write(email + " is Invalid Email \nPlease Enter Valid Email:- ");
                                    email = Console.ReadLine();
                                }//store email veriable
                                person.Email = email;                       //store class of person Email data
                                break;
                            case 7:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        foreach (Person t in list) //automate the reading  t of person of class
                        {
                            Console.WriteLine(t);//print list
                        }
                    }
                } //
                else
                {
                    Console.WriteLine($"{fname} Name of Record Not Found "); //Print Record not found
                }
            }
        }
        public void DeleteRecord(string firstName)  //Delte Record Method
        {
            for (int i = 0; i < list.Count; i++)   //Cheack record present or not
            {
                if (list[i].FirstName.Equals(firstName))  //Cheack list of record and user inpute same or not
                {
                    list.Remove(this.person); //Remove Record from Person class
                    Console.WriteLine($"{firstName} Name of Record Delete Successfully"); //Print Record Delete
                }
                else
                {
                    Console.WriteLine($"{firstName} Name of Record Not Found "); //Print Record not found
                }
            }
        }
        public bool CheckExist(string fname)  //Check exist method
        {
            int flag = 0;
            foreach (Person person in list) //Check list of class person
            {
                if (person.FirstName.Equals(fname)) //check first name and user input are equal or not
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                return true;
            }
            return false;
        }
        public void SearchRecordCityOrState()  //SearchRecordCityOrState Record Method
        {
            /* UC8:- Ability to search Person in a City or State across the multiple AddressBook
                     - Search Result can show multiple person in the city or state
         */
            Console.WriteLine("1.City\n2.State\nEnter Choice:-");

            int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1)
            {
                int count = 0;
                Console.WriteLine("Searching contact by City");
                Console.WriteLine("Enter City Name:-");
                string city = Console.ReadLine();

                for (int i = 0; i < list.Count; i++)   //Cheack record present or not
                {
                    if (list[i].City.Equals(city))  //Cheack list of record and user inpute same or not
                    {
                        count++;                     

                        Console.WriteLine($"Name:- { list[i].FirstName} City:- { list[i].City} "); //UC9 View person name and city

                    }
                    else
                    {
                        Console.WriteLine($"{city} City Name of Record Not Found "); //Print Record not found
                    }

                }                

            }
            else
            {
                int count = 0;
                Console.WriteLine("Search Record by State");
                Console.WriteLine("Enter State Name:-");
                string state = Console.ReadLine();

                for (int i = 0; i < list.Count; i++)   //Cheack record present or not
                {
                    if (list[i].State.Equals(state))  //Cheack list of record and user inpute same or not
                    {
                        count++;
                        Console.WriteLine($"Name:- { list[i].FirstName} State:- { list[i].State} "); //UC9 View person name and city
                    }
                    else
                    {
                        Console.WriteLine($"{state} State Name of Record Not Found "); //Print Record not found
                    }
                }
               
                Console.WriteLine($"\nNumber of contact in the City:- {state} are {count}");
            }
        }

    }
}

