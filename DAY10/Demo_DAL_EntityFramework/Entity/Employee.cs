using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DAL_EntityFramework.Entity
{
    public class Employee
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string getDetails()
        {
            return string.Format("No. : {0} | Name : {1} | Address :{2}",this.No,this.Name,this.Address);
        }
    }
}
