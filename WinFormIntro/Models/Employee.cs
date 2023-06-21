using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormIntro.Models
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }



    }


    class EmployeeContext
    {
        public List<Employee> Employees { get; } = new List<Employee> {
        
        new Employee { EmpID=1000, EmpName="Ganesh", Address="Blr" },
         new Employee { EmpID=1001, EmpName="Mahesh", Address="Chn" },
          new Employee { EmpID=1002, EmpName="Ramesh", Address="pun" },

        };





    }


}
