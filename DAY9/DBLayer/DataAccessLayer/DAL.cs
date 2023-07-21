using System;
using System.Collections.Generic;
using System.Configuration;
using DBLayer.Entities;
using System.Data.SqlClient;
using System.Linq;

namespace DBLayer.DataAccessLayer
{
    public class DAL
    {
        private String conStr = "";
        public DAL()
        {
            conStr = ConfigurationManager.ConnectionStrings["empCon"].ToString();
        }
        //ConfigurationManager reads App.config file

        public List<Employee> GetEmployee()
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from emp", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.No = Convert.ToInt32(reader["No"]);
                emp.Name = Convert.ToString(reader["Name"]);
                emp.Address = Convert.ToString(reader["Address"].ToString());
                employees.Add(emp);
            }

            conn.Close();
            return employees;
        }

        public List<Employee> GetEmployeesByCity(String Address)
        {
            List<Employee> allEmployees = GetEmployee();

            var filteredCollectionBasedOnCity = (from emp in allEmployees
                                                 where emp.Address.ToLower() == Address.ToLower()
                                                 select emp).ToList();
            return filteredCollectionBasedOnCity;

        }

        public Employee GetEmployeesByNo(int No)
        {
            List<Employee> allEmployees = GetEmployee();

            Employee filteredCollectionBasedOnNo = (from emp in allEmployees
                                                    where emp.No == No
                                                    select emp).ToList().First();
            return filteredCollectionBasedOnNo;

            //var filteredCollectionBasedOnNo = (from emp in allEmployees
            //                                 where emp.No == no
            //                                 select emp).ToList();
            //var searchedEmp = filteredCollectionBasedOnNo.First();
        }

        public bool AddEmployee(Employee emp)
        {
            SqlConnection conn = new SqlConnection(conStr);

            String query = "insert into emp (Name, address) values('{0}', '{1}')";
            String finalQuery = string.Format(query, emp.Name, emp.Address);
            SqlCommand cmd = new SqlCommand(finalQuery, conn);
            conn.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (noOfRowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee emp)
        {
            SqlConnection conn = new SqlConnection(conStr);

            String query = "update Emp set Name = '{1}', Address = '{2}' where No = {0}";
            String finalQuery = string.Format(query, emp.No, emp.Name, emp.Address);
            SqlCommand cmd = new SqlCommand(finalQuery, conn);
            conn.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (noOfRowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int No)
        {
            SqlConnection conn = new SqlConnection(conStr);

            String query = "delete from Emp where No = {0}";
            String finalQuery = string.Format(query, No);
            SqlCommand cmd = new SqlCommand(finalQuery, conn);
            conn.Open();
            int noOfRowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (noOfRowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
