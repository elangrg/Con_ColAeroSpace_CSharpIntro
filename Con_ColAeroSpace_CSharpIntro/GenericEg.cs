using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class GenericEg
    {
        static void Main()
        {
            Console.WriteLine(Min<int>(200, 10));
            Console.WriteLine(Min<string>("ABC", 1000.ToString()));
            Console.WriteLine(Min(200.50, 300.10));
            Console.WriteLine(Min(12,1));
            Console.WriteLine(Min("ABC","XYZ"));


            Console.WriteLine(GenericSyntaxEg<int, ClsDemo,string>(1000, new ClsDemo() ));

            List<CASEmployee> objLst = new List<CASEmployee>();


        }


        //static IComparable Min(IComparable a, IComparable b)
        //{
        //    if (a.CompareTo(b)<0)
        //    {
        //        return a;
        //    }
        //    else 
        //        return b;
        //}

        static T Min<T>(T a, T b) where T : IComparable<T>
        {


            if (a.CompareTo(b) < 0)
            {
                return a;
            }
            else
                return b;


        }


        static TR GenericSyntaxEg<T1, T2, TR>(T1 a, T2 b) where T1 : IComparable<T1>
                                                          where T2 : class,new()
        {
            T2 obj = new T2();

            Console.WriteLine(obj);


            return default(TR);
        
        }



        //static int Min(int a, int b)
        //{
        //    if (a<b)
        //    {
        //        return a;
        //    }
        //    else if (b<a)
        //        return b;

        //    return 0;

        //}

        //static double Min(double a, double b)
        //{
        //    if (a < b)
        //    {
        //        return a;
        //    }
        //    else if (b < a)
        //        return b;

        //    return 0;

        //}

    }


    class ClsDemo
    {




    }
}
