using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class ConstructorAndDestructor
    {
        static void Main()
        {

            //CASEmployee objEmp = new CASEmployee(1234,"Ganesh","Kormangala, Bangalore");
            //CASProjectManager objPM = new CASProjectManager();

            //EmployeeUtility employeeUtility = new EmployeeUtility();

            //Console.WriteLine($"Next EmpID value is '{EmployeeUtilityStaticConstrDemo.GetNextEmpID()}'");

            SingleTon obj = SingleTon.GetObject();
            Console.WriteLine(obj.SomeString);


            Console.ReadKey();
        }


    }




    class CASEmployee
    {        //public CASEmployee()
        //{
        //    _EmpID = 1000;
        //    FullName = "Not Set";
        //    Address = "Not Set";
        //    DOB=DateTime.Now.AddYears(-25);
        //}
                public CASEmployee(int empID, string fullName)//:this()
        {
            EmpID = empID;
            FullName = fullName;

        }
        public CASEmployee(int empID, string fullName, string address):this(empID, fullName)
        {
            Address = address;
        }

        private int _EmpID;
        public int EmpID
        {
            get { return _EmpID; }
            set { _EmpID = value; }
        }

        public string FullName { get; set; }

        public DateTime DOB { get; set; }

        public int Age
        {
            get { return DateTime.Now.Year - DOB.Year; }

        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set
            {
                if (value.Length > 10)
                {
                    _Address = value;
                }
                else
                    _Address = "Invalid";
            }
        }

        public override string ToString()
        {
            return $"Employee Id :{_EmpID} | Emp Name : {FullName} | Address : {Address} | Date of Birth :{DOB.ToString("dd MMM yyyy ddd")} | Age : {Age}";
        }
    }

    class CASProjectManager : CASEmployee
    {


        public CASProjectManager():base(-1000,"Not Set...")
        {

        }

        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" | Salary :{Salary} ";
        }

    }


    class EmployeeUtilityStaticConstrDemo
    {


        static EmployeeUtilityStaticConstrDemo()
        {
                _NextEmployeeID = "10010";
        }

       static  string _NextEmployeeID;

        public EmployeeUtilityStaticConstrDemo()
        {
          
        }

        public static string GetNextEmpID()
        {
            return _NextEmployeeID;
        }


        public string GetEmployeeDetailsByID(string empID)
        {
            return "";
        }


    }


    class SingleTon
    {
        static SingleTon _obj;

        public static SingleTon GetObject()
        {

            if (_obj==null)
            {
                _obj = new SingleTon();
            }

            return _obj;
        
        }

        private SingleTon()
        {

        }

        public string SomeString { get; set; } = "Value of SomeString Prop";


    }

}
