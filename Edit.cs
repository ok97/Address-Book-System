﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{           /* UC3:- Ability to edit existing contact person using their name - Use Console to edit person details
               UC4:- Ability to delete a person using person's name - Use Console to delete a person
            */
    class Edit  // Class Edit
    {
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
            Console.Write("Enter Phone Number:-"); //Take input user
            phone = Console.ReadLine();           //Store input for phone
            Console.Write("Enter Email:- ");  //Take input user
            email = Console.ReadLine();           //Store input for email
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
            for (int k = 0; k < list.Count; k++) //Value  present or not
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
                                Console.Write("Enter new Street:-  ");  //Take input user
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
                                person.PhoneNo = phone;                 //store class of person phone data
                                break;
                            case 4:
                                Console.Write("Enter new Zip Code:- "); //Take input user
                                String zip = Console.ReadLine();        //store zip veriable
                                person.ZipCode = zip;                       //store class of person zip data
                                break;
                            case 6:
                                Console.Write("Enter new Email:- "); //Take input user
                                String email = Console.ReadLine();         //store email veriable
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
                } //end of edit() method
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
    }
}
