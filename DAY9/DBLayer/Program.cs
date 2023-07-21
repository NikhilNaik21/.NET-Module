using System;
using DBLayer.Entities;
using DBLayer.DataAccessLayer;
using System.Collections.Generic;

namespace DBLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAL dbEntities = new DAL();

            while(true)
            {
                Console.WriteLine("Enter ur choice.");
                Console.WriteLine("1. Get All Employees\n2. Get All Employees based on city\n3. Get Employee based on No\n4. Add Employee\n5. Update Employee\n6. Delete Employee");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: //Get All Employees
                        List<Employee> allEmployees = dbEntities.GetEmployee();
                        foreach (Employee emps in allEmployees)
                        {
                            Console.WriteLine(emps.getDetails());
                        }
                        break;

                    case 2: //Get All Employees based on city
                        Console.WriteLine("Enter a city to be search.");
                        String city = Console.ReadLine();
                        List<Employee> allEmployeesByCity = dbEntities.GetEmployeesByCity(city);
                        foreach (Employee emps in allEmployeesByCity)
                        {
                            Console.WriteLine(emps.getDetails());
                        }
                        break;

                    case 3: //Get Employee based on No
                        Console.WriteLine("Enter No of Employee to be search.");
                        int No = Convert.ToInt32(Console.ReadLine());
                        Employee emp = dbEntities.GetEmployeesByNo(No);
                        Console.WriteLine(emp.getDetails());
                        break;

                    case 4: //Add Employee
                        Employee empToBeAdded = new Employee();

                        Console.WriteLine("Enter Name of Employee.");
                        empToBeAdded.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address of Employee.");
                        empToBeAdded.Address = Console.ReadLine();

                        bool result = dbEntities.AddEmployee(empToBeAdded);
                        if (result)
                        {
                            Console.WriteLine("Employee added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error.");
                        }
                        break;

                    case 5: //Update Employee
                        Employee empToBeUpdate = new Employee();

                        Console.WriteLine("Enter No of Employee.");
                        empToBeUpdate.No = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name of Employee.");
                        empToBeUpdate.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address of Employee.");
                        empToBeUpdate.Address = Console.ReadLine();

                        bool updateResult = dbEntities.UpdateEmployee(empToBeUpdate);
                        if (updateResult)
                        {
                            Console.WriteLine("Employee updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error.");
                        }
                        break;

                    case 6: //Delete Employee
                        Console.WriteLine("Enter No of Employee.");
                        int noDelete = Convert.ToInt32(Console.ReadLine());


                        bool deleteResult = dbEntities.DeleteEmployee(noDelete);
                        if (deleteResult)
                        {
                            Console.WriteLine("Employee deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error.");
                        }
                        break;

                    default:
                        Console.WriteLine("Enter a valid choice.");
                        break;
                }

                Console.WriteLine("Do u want to continue ? y/n");
                string ch = Console.ReadLine();
                if (ch == "n")
                {
                    break;
                }
            }

            
        }
    }
}
