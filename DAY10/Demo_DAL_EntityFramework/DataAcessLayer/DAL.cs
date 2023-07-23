using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Demo_DAL_EntityFramework.Entity;
using System.Data.SqlClient;

namespace Demo_DAL_EntityFramework.DataAcessLayer
{
    public class DAL
    {
        private string conStr = " ";
        public DAL()
        {
            conStr = ConfigurationManager.ConnectionStrings["empCon"].ToString();
        }

        public List<Employee> GetEmployee()
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from Emp", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.No = Convert.ToInt32(reader["No"]);
                emp.Name = Convert.ToString(reader["Name"]);
                emp.Address = Convert.ToString(reader["Address"]);
                employee.Add(emp);
            }
            conn.Close();
            return employee; 
        }

        public List<Employee>GetEmployeesByCity(string city)
        {
            List<Employee> allEmployees = GetEmployee();
            var filterEmpCollectionByCity = (from emp in allEmployees
                                             where emp.Address.ToLower() == city.ToLower()
                                             select emp).ToList();
            return filterEmpCollectionByCity;
        }

        public Employee GetEmployeeByNo(int no)
        {
            List<Employee> allEmployees = GetEmployee();
            Employee filterEmpByNo = (from emp in allEmployees
                                      where emp.No == no
                                      select emp).ToList().First();
            return filterEmpByNo;
        }

        public bool AddEmployee(Employee emp)
        {
            string quarry = "insert into Emp(Name,Address) values ('{0}','{1}')";
            string finalQuarry = string.Format(quarry, emp.Name, emp.Address);
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(finalQuarry,conn);
            conn.Open();

            int noOfRowAffected = cmd.ExecuteNonQuery();
            if(noOfRowAffected > 0) { return true; }
            else { return false; }
        }

        public bool UpdateEmployee(Employee emp)
        {
            string quarry = "update Emp set Name ='{1}', Address = '{2}' where No = {0}";
            string finalQuarry = string.Format(quarry,emp.No, emp.Name, emp.Address);
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(finalQuarry, conn);
            conn.Open();

            int noOfRowAffected = cmd.ExecuteNonQuery();
            if (noOfRowAffected > 0) { return true; }
            else { return false; }
        }

        public bool DeleteEmployee(int no )
        {
            string quarry = "delete from Emp where No = {0}";
            string finalQuarry = string.Format(quarry, no);
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(finalQuarry, conn);
            conn.Open();

            int noOfRowAffected = cmd.ExecuteNonQuery();
            if (noOfRowAffected > 0) { return true; }
            else { return false; }
        }
    }
}
