using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using A2;

namespace A23
{
    class program
    {
        static void Main(string[] args)
        {            
            List<Staff> employee = new List<Staff>(); //used to create a new list of Staff objects.
            Console.Write("Input the number of people: ");            
            int number = int.Parse(Console.ReadLine()); //Used to enter the number of employees to be imported.
            for (int i = 0; i < number; i++) //Create a loop to enter information for each employee.
            {
                Console.WriteLine("Enter 1 for a Intern, 2 for a Official Employee, or 3 for a Long-time Employee:");
                Console.WriteLine();
                Console.WriteLine("1. Interns have a basic salary of $3,000. They have overtime and salary deductions, but no bonuses.");
                Console.WriteLine();
                Console.WriteLine("2. Official employees have a basic salary of $4,000. They have overtime pay, salary deductions and bonuses.");
                Console.WriteLine();
                Console.WriteLine("3. Long-term employees receive a basic salary calculated on an annual basis. They are overtime pay, salary deductions and bonuses.");
                Console.WriteLine();
                int choice = int.Parse(Console.ReadLine());//Used to enter employee level selection.                
                Staff staff; //Used to create a new Staff object.
                switch (choice) 
                {
                    case 1://Enter 1 to choose to enter information for interns.
                    staff = new SalaryInterns(); //Means that the "staff" variable is now a "SalaryInterns" object.                    
                    ((SalaryInterns)staff).Input(); //Casts the "staff" object to a "SalaryInterns" object and then calls the "Input()" method on the "SalaryInterns" object.
                    employee.Add(staff);//Add the "staff" object to the "employee" list
                        break;
                    case 2: //Enter 2 to choose to enter information for Official Employee.
                    staff = new SalaryOfficialEmployees(); //Means that the "staff" variable is now a "SalaryOfficialEmployees" object.                    
                    ((SalaryOfficialEmployees)staff).Input(); //Casts the "staff" object to a "SalaryInterns" object and then calls the "Input()" method on the "SalaryOfficialEmployees" object.
                    employee.Add(staff);//Add the "staff" object to the "employee" list
                        break;
                    case 3: //Enter 3 to choose to enter information for Long-time Employee.
                    staff = new SalaryLong_timeEmployees(); //Means that the "staff" variable is now a "SalaryLong_timeEmployees" object.
                    ((SalaryLong_timeEmployees)staff).Input(); //Casts the "staff" object to a "SalaryInterns" object and then calls the "Input()" method on the "SalaryLong_timeEmployees" object.                   
                    employee.Add(staff);//Add the "staff" object to the "employee" list
                        break;
                    default://Entering numbers other than 1,2 and 3 will display "Invalid selection".
                    Console.WriteLine("Invalid choice.");
                        break;
                } 
            }
            // Creates a new list of "Staff" objects that is sorted by the "FullName" property in ascending order. 
            Console.WriteLine();
            Console.WriteLine("List of Staff");
            Console.WriteLine();
            // Iterates through the "employee" list and returns only the "Staff" objects that are instances of the Staff.
            foreach (Staff staff in employee)
            {
                staff.ToString();
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}