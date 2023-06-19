using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    delegate int dlgDemo(int a, int b);


    internal class DelegateEg
    {

        static void Main()
        {

          //  dlgDemo fptr = new dlgDemo(Add); 1.0 syntax
            dlgDemo fptr = Add; //2.0
            fptr += Multi;

            // 2.0 Anonymous Block or Method
            fptr += delegate (int x, int y) { return x + y; };

            // 3.0 Lambda Expression
                // Explicitly Typed Arg with Block Body
            fptr +=  (int x, int y) => { return x + y; };

            // Implictly Typed arg with block Body
            fptr +=  ( x, y) =>{ return x + y; };

            // Implictly Typed arg with expression Body
            fptr += (x, y) =>  x + y; 

            Console.WriteLine(fptr(100,200));



            //.net ver 4.0 Generic Delegates Func<> , Action

            Func<int,int,int> mptr= (i,j)=>i+j;

            Console.WriteLine(mptr(100,200));


            Action<string> aptr = (msg) => Console.WriteLine(msg);

            aptr += msg => Console.WriteLine(msg);

            aptr("Hello!!!");



        }

        static int Add(int i, int j)
        { return i + j; }

 static int Multi(int k, int l)
        { return k * l; }

    }
}
