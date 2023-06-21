using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class usingAssemblyEg
    {

        static void Main()
        { 
            clbMath.clsMath obj = new clbMath.clsMath();
            Console.WriteLine( " Add Called result " +   obj.Add(100, 200));



        }

    }
}
