using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome To AddressBook ****");           
            int i = 0;
            Edit edit = new Edit(); //Create object Edit class
            while (i == 0)
            {
                Console.WriteLine("\n1. Add New Person      ");
                Console.WriteLine("2. Display Records     ");
                Console.WriteLine("3. Edit Records        ");
                Console.WriteLine("4. Delete Records      ");                
                Console.WriteLine("5. Exit		        \n");
                Console.Write("Enter Your Choice:- ");
                //String opt = Console.ReadLine();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        edit.AddRecord(); //call AddRecord Method
                        break;
                    case 2:
                        edit.DisplayRecord();  //call DisplayRecord Method
                        break;
                    case 3:
                        Console.Write("Enter First Name To Edit Records:- ");
                        String firstName = Console.ReadLine();
                        edit.EditRecord(firstName); //call Edit record method
                        break;
                    case 4:                        
                        Console.Write("Enter First Name To Delete Records:- ");
                        String Name = Console.ReadLine();
                        edit.DeleteRecord(Name); //call Delete record method
                        break;                    
                    case 5:
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Option");
                        break;
                }
            }
        }
    }
}
