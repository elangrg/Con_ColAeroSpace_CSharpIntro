using System;
using System.Collections.Generic;
//using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class MISC_2_3
    { 
        
        
        static void Main()
        {
            // PartialClassEg obj = new PartialClassEg();

            // NullableEg();

            //TypeInferenceEg();

            //ObjectInitializerAndAnonymousTypeEg();


            // traditional Style 
            char abc = 'a';
            ExtensionMethodEg.IsValidEmployeeIdChar(abc);

            abc.IsValidEmployeeIdChar();

            string st = "";
            st.IsValidEmployeeIdChar();

            Course objc = new Course();
            objc.IsValidEmployeeIdChar();


            


            Console.ReadKey();









        }

        private static void ObjectInitializerAndAnonymousTypeEg()
        {
            Course objCourse = new Course { Duration = 40, CourseName = "ASP.NET Core" };
            var objCourse1 = new Course { Duration = 40, CourseName = "ASP.NET Core MVC" };

            // Anonymous Type 3.0
            var objCourse2 = new { Duration = 40, CourseName = "ASP.NET Core MVC" };
            var objCourse3 = new { Duration = 20, CourseName = " EF Core " };

            var objCourse4 = new { CourseName = " EF Core ", Duration = 20 };


            Console.WriteLine(objCourse1.GetType());
            Console.WriteLine(objCourse2.GetType());
            Console.WriteLine(objCourse3.GetType());
            Console.WriteLine(objCourse4.GetType());
        }

        private static void TypeInferenceEg()
        {
            var i = 100;
            i = 200;

            var j = default(EmployeeList);

            #region Dynamic Typing 
            dynamic demo = default(dynamic);
            demo.akjsdfghdgfhagfaghfj();
            demo.abc = "";




            DynamicTypingEg.Execute();
            #endregion
        }

        private static void NullableEg()
        {
            // nullable

            int? i = null;

            Nullable<int> j = null;
            if (i.HasValue)
            {

                Console.WriteLine(i.Value);
            }
        }
    
        
    }


    static class StaticClassEg
    {
        static  StaticClassEg()
        {

        }
        public static void Display()
        {
            Console.WriteLine("Hello Static Class!!");
        
        }




    }


    public partial class PartialClassEg
    {

        public int SomeProp1 { get; set; }

        public void SomeMethod1()
        { 
        
        
        }



    }



    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }


    }


    static class ExtensionMethodEg
    {

        public static bool IsValidEmployeeIdChar(this object empid)
        {
            return true;
        }


    }


}
