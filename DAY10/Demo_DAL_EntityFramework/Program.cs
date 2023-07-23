using System;
using System.Collections.Generic;
using Demo_DAL_EntityFramework.DataAcessLayer;
using Demo_DAL_EntityFramework.Entity;

namespace Demo_DAL_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAL dbEntity = new DAL();

            while (true)
            {
                Console.WriteLine("Enter your choice :");
                Console.WriteLine("1. Get All Employee Records");
                Console.WriteLine("2. Get All Employee Records Based on City");
                Console.WriteLine("3. Get Employee Records Based on No");
                Console.WriteLine("4. Add Employee Records");
                Console.WriteLine("5. Update Employee Records");
                Console.WriteLine("6. Remove Employee Records");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                { 
                    
                    case 1:
                        List<Employee> allEmployees = dbEntity.GetEmployee();
                        foreach(Employee emp in allEmployees)
                        {
                            Console.WriteLine(emp.getDetails());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter City Name :");
                        string city = Console.ReadLine();
                        List<Employee> empByCity = dbEntity.GetEmployeesByCity(city);
                        foreach(Employee emp1 in empByCity)
                        {
                            Console.WriteLine(emp1.getDetails());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter No of Employee want to search :");
                        int no = Convert.ToInt32(Console.ReadLine());
                        Employee emp2 = dbEntity.GetEmployeeByNo(no);                   
                        Console.WriteLine(emp2.getDetails());
                        break;
                    case 4:
                        Employee emp3 = new Employee();
                        Console.WriteLine("Enter Employee Name For Added :");
                        emp3.Name = (Console.ReadLine());
                        Console.WriteLine("Enter Employee Address For Added :");
                        emp3.Address = (Console.ReadLine());
                        
                        bool res = dbEntity.AddEmployee(emp3);
                        if(res)
                        {
                            Console.WriteLine("Record Added ");
                        }
                        else { Console.WriteLine("Error  "); }
                        break;
                    case 5:
                        Employee emp4 = new Employee();
                        Console.WriteLine("Enter Employee No For Updated :");
                        emp4.No =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name For Updated :");
                        emp4.Name = (Console.ReadLine());
                        Console.WriteLine("Enter Employee Address For Updated :");
                        emp4.Address = (Console.ReadLine());

                        bool result = dbEntity.UpdateEmployee(emp4);
                        if (result)
                        {
                            Console.WriteLine("Record Updated ");
                        }
                        else { Console.WriteLine("Error  "); }
                        break;
                    case 6:
                        Console.WriteLine("Enter Employee No For Deleted :");
                        int No1 = Convert.ToInt32(Console.ReadLine());
                        bool result1 = dbEntity.DeleteEmployee(No1);
                        if (result1)
                        {
                            Console.WriteLine("Record Deleted ");
                        }
                        else { Console.WriteLine("Error  "); }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? y/n");
                string ch = Console.ReadLine();
                if (ch == "n")
                {
                    break;
                }
            }
                 Console.ReadLine();
        }
       
    }
}
