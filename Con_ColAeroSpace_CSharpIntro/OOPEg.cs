using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro.oopsdemo
{
    internal class OOPEg
    {

        static void Main()
        {
            // BasicOOPIntro();
            

            CASEmployee objEmp = new CASEmployee(0,"");

            objEmp.EmpID = 1000;
            objEmp.FullName = "Ganesh";
            objEmp.DOB = DateTime.Now.AddDays(-10000);
            //objEmp.Age = 123;

            objEmp.Address = "Bangalore";

            Console.WriteLine(objEmp);

            CASProjectManager objPM = new CASProjectManager();
            objPM.EmpID = 2000;
            objPM.FullName = "Mahesh";
            objPM.DOB = DateTime.Now.AddDays(-15000);
           
            objPM.Address = "Bangalore";
            objPM.Salary = 10000000;


            Console.WriteLine(objPM);
        }

        private static void BasicOOPIntro()
        {
            ClsA objA = new ClsB();

            objA.Display();

            ClsB objB = new ClsC();
            objB.Display();

            objA = objB;
            objA.Display();

            objB = (ClsB)objA;

            objB = objA as ClsB;

            objB.Display();
        }
    }


   abstract class ClsA
    {
        public abstract void Display();
        //{
        //    Console.WriteLine("In Display Of Cls A");
        //}
    }

    class ClsB : ClsA
    {
        public sealed override void Display()
        {
            Console.WriteLine("In Display Of Cls B");
        }
    }
class ClsC : ClsB
    {
        //public override void Display()
        //{
        //    Console.WriteLine("In Display Of Cls C");
        //}
    }


    #region Class intro Level 1
    //class ClsA
    //{
    //    private int var_prv=100;
    //    public int var_pub = 100;
    //    protected int var_prd=100;
    //    int var_Defa = 100;

    //}

    //class ClsB:ClsA
    //{
    //    public ClsB()
    //    {

    //        var_prd = 200;




    //    }



    //} 
    #endregion



}
