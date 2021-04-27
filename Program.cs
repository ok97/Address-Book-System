using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {    
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>(); //list           
            // AddingDetails(list); //call method
            // RetriveTop2Record(list);
            // RetriveRecordAge13to18(list);
            // RetriveAverageAgeRecord(list);
            // RecordNamePersonPresentOrNot(list);
            // SkipRecordAgelessthan60(list);
           //  RemoveSpecificName(list);
            Console.ReadLine();
        }
        public static void AddingDetails(List<Person> list) //create Adding Detialaccess method 
        {  /* UC1:- Person Data Management 
                    - Create Person class with SSN, Name, Address and Age fields.
                    - Create variable for List of Person class in Main method. 
                    - Add default values in created list.
            */
            
            String input = Console.ReadLine();
            list.Add(new Person() { SNN = 1, Age = 23, Name = "Omprakash", Address = "Nagpur" }); //Adding item in list
            list.Add(new Person() { SNN = 2, Age = 17, Name = "Vishal", Address = "Mumbai" }); //Adding item in list
            list.Add(new Person() { SNN = 3, Age = 23, Name = "Ekta", Address = "Pune,Aund" }); //Adding item in list
            list.Add(new Person() { SNN = 4, Age = 16, Name = "Ram", Address = "Aund" });  //Adding item in list
            list.Add(new Person() { SNN = 5, Age = 85, Name = "Sham", Address = "Pimpri" });  //Adding item in list
            list.Add(new Person() { SNN = 6, Age = 75, Name = "Rag", Address = "Wadi" }); //Adding item in list

            foreach (Person List in list) //iterate list
            {
                Console.WriteLine($"SSN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address} "); //Print Record of the list
            }


        }
        public static void RetriveTop2Record(List<Person> list) //create Retrive Method 
        {  /* UC2:- Person Data Management
                    - Retrieve top 2 records from the list for age is less than 60
            */
            Console.WriteLine("\n\n");
            var Result = list.FindAll(x => x.Age < 60).OrderBy(x => x.Age).Take(2); //using Lambda Expression find age is less than and print top 2 Record
            foreach (var List in Result) //iterate list
            {
                Console.WriteLine($"SNN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address}"); //Print Top 2 Record
            }
        }

        public static void RetriveRecordAge13to18(List<Person> list) //Create RetriveRecordAge13to18 method
        {   /*UC3:- Person Data Management. 
                    - Retrieve all record from the list for age between 13 to 18.
             */
            Console.WriteLine("\n\n");
            var Tenage = list.FindAll(x => x.Age > 13 && x.Age <= 18); //Using lambda Expression find Age >13 and lass than <18
            foreach (var List in Tenage)  //iterate list
            {
                Console.WriteLine($"SNN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address}"); //Print Record
            }
        }
        public static void RetriveAverageAgeRecord(List<Person> list) //Create RetriveAverageAgeRecord method
        {   /* UC4:- Person Data Management 
                     - Retrieve average age in the list.             
             */
            Console.WriteLine("\n\n");
            var AvgAge = list.Average(x => x.Age); //Using lambda Expression find Average Age

            Console.WriteLine($"Average Age in List is {AvgAge}"); //print Average Age

        }
        public static void RecordNamePersonPresentOrNot(List<Person> list) //Create RecordNamePersonPresentOrNot method
        {  /*UC5:- Person Data Management.
                   - Check for specific name present in the list or not.
            */
            try
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Enter a Name:-"); //take input from user
                string name = Console.ReadLine(); //read input and store name
                var search = list.Where(x => x.Name.Equals(name)).FirstOrDefault();//FirstOrDefault is use to dont run any exception //Using lambda Expression search name using equal method
                if (search != null) //name is present go if block
                {
                    Console.WriteLine($"{name} is Present in List"); //print
                    Console.WriteLine($"SNN:- {search.SNN} Age:- {search.Age} Name:- {search.Name} Address:- {search.Address}"); //Print Record

                }
                else
                {
                    Console.WriteLine($"{name} Record Not Found in List"); //print
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message); //print message
            }
        }

        public static void SkipRecordAgelessthan60(List<Person> list) //Create SkipRecordAgelessthan60 method
        {      /* UC6:- Person Data Management 
                        - Skip record from the list for age is less than 60.
                */

            var skip60 = list.FindAll(x=>x.Age>60); //Using lambda Expression find list record Age is >60 
            foreach (var List in skip60)  //iterate list
            {
                Console.WriteLine($"SNN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address}"); //Print Record
            }

        }
        public static void RemoveSpecificName(List<Person> list) //Create SkipRecordAgelessthan60 method
        {  /* UC7:- Person Data Management.
                    - Remove specific name from the .list
            */
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter a Name:-"); //take input from user
            string name = Console.ReadLine(); //read input and store name
            var search = list.Where(x => x.Name.Equals(name)).FirstOrDefault();//FirstOrDefault is use to dont run any exception //Using lambda Expression search name using equal method
            if (search != null) //name is present go if block
            {
                Console.WriteLine($"{name} is Present in List"); //print

                list.Remove(search); //Delete name of Data in list
                Console.WriteLine($"{name} Delete Successfully in List"); //print
               
                foreach (Person List in list) //iterate list
                {
                    Console.WriteLine($"SSN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address} "); //Print Record of the list
                }
            }
            else
            {
                Console.WriteLine($"{name} Record Not Found in List"); //print
            }
        }


    }
}
